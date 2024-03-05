// using Assets.Scripts.Data;
// using UnityEngine;
// using UnityEngine.Purchasing;

// namespace Assets.Scripts.Core
// {
// 	public class PurchaseManager : MonoBehaviour, IStoreListener
// 	{
// 		//private static PurchaseManager _instance;
// 		//public static PurchaseManager Instance { get { return _instance; } }

// 		private IStoreController controller;
// 		private IExtensionProvider extensions;

// 		private void Start()
// 		{
// 			if (controller == null)
// 			{
// 				InitializePurchasing();
// 			}
// 		}

// 		//void Awake()
// 		//{
// 		//	if (_instance != null && _instance != this)
// 		//	{
// 		//		Destroy(gameObject);
// 		//	}
// 		//	else
// 		//	{
// 		//		_instance = this;
// 		//		DontDestroyOnLoad(gameObject);
// 		//	}

// 		//	InitializePurchasing();
// 		//}

// 		public void InitializePurchasing()
// 		{
// 			if (IsInitialized()) return;
// 			var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
// 			builder.AddProduct("donation_01", ProductType.Consumable);
// 			builder.AddProduct("donation_02", ProductType.Consumable);
// 			builder.AddProduct("donation_04", ProductType.Consumable);
// 			builder.AddProduct("donation_06", ProductType.Consumable);
// 			UnityPurchasing.Initialize(this, builder);
// 		}

// 		private bool IsInitialized()
// 		{
// 			return controller != null && extensions != null;
// 		}

// 		public void BuyProductID(string productId)
// 		{
// 			if (IsInitialized())
// 			{
// 				Product product = controller.products.WithID(productId);

// 				if (product != null && product.availableToPurchase)
// 				{
// 					Debug.Log(string.Format("Purchasing product asychronously: '{0}'", product.definition.id));
// 					controller.InitiatePurchase(product);
// 				}
// 				else
// 				{
// 					Debug.Log("BuyProductID: FAIL. Not purchasing product, either is not found or is not available for purchase");
// 				}
// 			}
// 			else
// 			{
// 				Debug.Log("BuyProductID FAIL. Not initialized.");
// 			}
// 		}

// 		public void RestorePurchases()
// 		{
// 			if (!IsInitialized())
// 			{
// 				Debug.Log("RestorePurchases FAIL. Not initialized.");
// 				return;
// 			}

// 			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.OSXPlayer)
// 			{
// 				Debug.Log("RestorePurchases started ...");

// 				var apple = extensions.GetExtension<IAppleExtensions>();
// 				apple.RestoreTransactions((result) =>
// 				{
// 					Debug.Log("RestorePurchases continuing: " + result + ". If no further messages, no purchases available to restore.");
// 				});
// 			}
// 			else
// 			{
// 				Debug.Log("RestorePurchases FAIL. Not supported on this platform. Current = " + Application.platform);
// 			}
// 		}

// 		public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
// 		{
// 			this.controller = controller;
// 			this.extensions = extensions;
// 		}

// 		public void OnInitializeFailed(InitializationFailureReason error)
// 		{
// 			Debug.Log("OnInitializeFailed InitializationFailureReason:" + error);
// 		}

// 		public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
// 		{
// 			Debug.Log(string.Format("ProcessPurchase: PASS. Product: '{0}'", e.purchasedProduct.definition.id));

// 			HudManager.Instance.UserData.HasDonated = true;
// 			Database.Save(HudManager.Instance.UserData);
// 			AdManager.DonatedComplete();

// 			return PurchaseProcessingResult.Complete;
// 		}

// 		public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
// 		{
// 			Debug.Log(string.Format("OnPurchaseFailed: FAIL. Product: '{0}', PurchaseFailureReason: {1}", i.definition.storeSpecificId, p));
// 		}

// 		//public bool HasBought()
// 		//{
// 		//	if (!IsInitialized()) return false;

// 		//	foreach (var item in controller.products.all)
// 		//	{
// 		//		if (item.hasReceipt)
// 		//			return true;
// 		//	}

// 		//	return false;
// 		//}
// 	}
// }