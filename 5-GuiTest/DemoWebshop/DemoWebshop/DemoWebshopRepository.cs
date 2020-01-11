﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace DemoWebshop
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the DemoWebshopRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("505cd157-f827-40d9-bf71-1e6dedeb8d6c")]
    public partial class DemoWebshopRepository : RepoGenBaseFolder
    {
        static DemoWebshopRepository instance = new DemoWebshopRepository();
        DemoWebshopRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        DemoWebshopRepositoryFolders.DemoWebShopGoogleChromeAppFolder _demowebshopgooglechrome;

        /// <summary>
        /// Gets the singleton class instance representing the DemoWebshopRepository element repository.
        /// </summary>
        [RepositoryFolder("505cd157-f827-40d9-bf71-1e6dedeb8d6c")]
        public static DemoWebshopRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public DemoWebshopRepository() 
            : base("DemoWebshopRepository", "/", null, 0, false, "505cd157-f827-40d9-bf71-1e6dedeb8d6c", ".\\RepositoryImages\\DemoWebshopRepository505cd157.rximgres")
        {
            _applicationundertest = new DemoWebshopRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _demowebshopgooglechrome = new DemoWebshopRepositoryFolders.DemoWebShopGoogleChromeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("505cd157-f827-40d9-bf71-1e6dedeb8d6c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("db975c3b-443e-4487-9e1b-3fc4ab0f40d7")]
        public virtual DemoWebshopRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The DemoWebShopGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("d7955e27-6d1f-4a16-978b-bb738c048555")]
        public virtual DemoWebshopRepositoryFolders.DemoWebShopGoogleChromeAppFolder DemoWebShopGoogleChrome
        {
            get { return _demowebshopgooglechrome; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class DemoWebshopRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("db975c3b-443e-4487-9e1b-3fc4ab0f40d7")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            DemoWebshopRepositoryFolders.AddToCartFolder _addtocart;
            RepoItemInfo _loginInfo;
            RepoItemInfo _emailInfo;
            RepoItemInfo _submitInfo;
            RepoItemInfo _kaasmetuiensausathotmailcomInfo;
            RepoItemInfo _logoutInfo;
            RepoItemInfo _smallsearchtermsInfo;
            RepoItemInfo _theproducthasbeenaddedtoyourInfo;
            RepoItemInfo _shoppingcartInfo;
            RepoItemInfo _strongtag40400Info;
            RepoItemInfo _smartphoneInfo;
            RepoItemInfo _bluejeansInfo;
            RepoItemInfo _updatecartInfo;
            RepoItemInfo _divtagyourshoppingcartiseInfo;
            RepoItemInfo _footermenuwrapperInfo;
            RepoItemInfo _removefromcartInfo;
            RepoItemInfo _removefromcart1Info;
            RepoItemInfo _h1tagsmInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='demowebshop.tricentis.com']", parentFolder, 30000, null, false, "db975c3b-443e-4487-9e1b-3fc4ab0f40d7", "")
            {
                _addtocart = new DemoWebshopRepositoryFolders.AddToCartFolder(this);
                _loginInfo = new RepoItemInfo(this, "LogIn", "body/div[4]/div[1]/div[1]/div[2]/?/?/ul/?/?/a[@innertext='Log in']", 30000, null, "8ca9c25d-5f05-461e-801a-b91346a52dc6");
                _emailInfo = new RepoItemInfo(this, "Email", ".//input[#'Email']", 30000, null, "4acc2288-d147-45e5-b8c7-6f17e8f02c76");
                _submitInfo = new RepoItemInfo(this, "Submit", "body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[1]//form[@action='http://demowebshop.tricentis.com/login']/div[5]/input[@type='submit']", 30000, null, "33cd732a-3940-4b99-8862-e6352077bea8");
                _kaasmetuiensausathotmailcomInfo = new RepoItemInfo(this, "KaasmetuiensausAthotmailCom", "body/div[4]/div[1]/div[1]/div[2]/?/?/ul/?/?/a[@innertext>'kaasmetuiensaus@hotmail.c']", 30000, null, "e2ac6fb2-51cb-4c13-8e65-3c1532d3759f");
                _logoutInfo = new RepoItemInfo(this, "LogOut", "body/div[4]/div[1]/div[1]/div[2]/?/?/ul/?/?/a[@innertext='Log out']", 30000, null, "795c761f-cb40-46a9-bc5f-1c46a9c1ec89");
                _smallsearchtermsInfo = new RepoItemInfo(this, "SmallSearchterms", ".//input[#'small-searchterms']", 30000, null, "f200793b-6911-4f6f-bbe6-33001e5cc962");
                _theproducthasbeenaddedtoyourInfo = new RepoItemInfo(this, "TheProductHasBeenAddedToYour", ".//div[#'bar-notification']/p[@innertext>'The product has been added']", 30000, null, "379ce825-b737-4699-83ca-c358762ba0e8");
                _shoppingcartInfo = new RepoItemInfo(this, "ShoppingCart", ".//li[#'topcartlink']/?/?/span[@innertext='Shopping cart']", 30000, null, "e9d0e5fd-16e3-4475-952e-b8b6ea33028a");
                _strongtag40400Info = new RepoItemInfo(this, "StrongTag40400", "body/div[4]/div[1]/div[4]//form[@action='http://demowebshop.tricentis.com/cart']/div[2]/div[2]/div[1]/table/tbody/tr[4]/td[2]//strong[@innertext='404.00']", 30000, null, "76678ae3-7dd7-4b24-99cd-eeecbceb862f");
                _smartphoneInfo = new RepoItemInfo(this, "Smartphone", "body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[3]//h2/a[@innertext='Smartphone']", 30000, null, "c034d8b4-b895-4719-a66b-e7308c61b5de");
                _bluejeansInfo = new RepoItemInfo(this, "BlueJeans", "body/div[4]/div[1]/div[4]/div[2]/div/div[2]/div[3]//h2/a[@innertext='Blue Jeans']", 30000, null, "54478cbf-d3c1-46b4-80d4-b9e055278495");
                _updatecartInfo = new RepoItemInfo(this, "Updatecart", "body/div[4]/div[1]/div[4]//form[@action='http://demowebshop.tricentis.com/cart']/div[1]/?/?/input[@name='updatecart']", 30000, null, "e153eca8-ea1a-4136-b51e-50c27213f99e");
                _divtagyourshoppingcartiseInfo = new RepoItemInfo(this, "DivTagYourShoppingCartIsE", "body/div[4]/div[1]/div[4]//div[@innertext>'        Your Shopping Cart']", 30000, null, "005a2bc6-6895-4abe-840d-295b2df09f2d");
                _footermenuwrapperInfo = new RepoItemInfo(this, "FooterMenuWrapper", "body/div[4]/div[2]/div[1]", 30000, null, "8c604974-0e0d-45d9-8fa1-ea5a057ad6a2");
                _removefromcartInfo = new RepoItemInfo(this, "Removefromcart", "body/div[4]/div[1]/div[4]//form[@action='http://demowebshop.tricentis.com/cart']/table/tbody/tr[1]/td[1]/input[@name='removefromcart']", 30000, null, "fb6e1501-b455-4907-a0be-a09d78a776db");
                _removefromcart1Info = new RepoItemInfo(this, "Removefromcart1", "body/div[4]/div[1]/div[4]/descendant-or-self::*/div[@class='order-summary-content']/form[@action='http://demowebshop.tricentis.com/cart']/table[@class='cart']/tbody/tr[2]/td[1]/input[@name='removefromcart']", 30000, null, "c5afb92f-0e5d-485c-b165-cdfb39e0ff71");
                _h1tagsmInfo = new RepoItemInfo(this, "H1TagSm", ".//form[#'product-details-form']/div/div[1]/div[2]/div[1]/h1[@innertext>'']", 30000, null, "c9ff4683-e1a4-4783-86b6-2a410aa41a8b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("db975c3b-443e-4487-9e1b-3fc4ab0f40d7")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("db975c3b-443e-4487-9e1b-3fc4ab0f40d7")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The LogIn item.
            /// </summary>
            [RepositoryItem("8ca9c25d-5f05-461e-801a-b91346a52dc6")]
            public virtual Ranorex.ATag LogIn
            {
                get
                {
                    return _loginInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LogIn item info.
            /// </summary>
            [RepositoryItemInfo("8ca9c25d-5f05-461e-801a-b91346a52dc6")]
            public virtual RepoItemInfo LogInInfo
            {
                get
                {
                    return _loginInfo;
                }
            }

            /// <summary>
            /// The Email item.
            /// </summary>
            [RepositoryItem("4acc2288-d147-45e5-b8c7-6f17e8f02c76")]
            public virtual Ranorex.InputTag Email
            {
                get
                {
                    return _emailInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Email item info.
            /// </summary>
            [RepositoryItemInfo("4acc2288-d147-45e5-b8c7-6f17e8f02c76")]
            public virtual RepoItemInfo EmailInfo
            {
                get
                {
                    return _emailInfo;
                }
            }

            /// <summary>
            /// The Submit item.
            /// </summary>
            [RepositoryItem("33cd732a-3940-4b99-8862-e6352077bea8")]
            public virtual Ranorex.InputTag Submit
            {
                get
                {
                    return _submitInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit item info.
            /// </summary>
            [RepositoryItemInfo("33cd732a-3940-4b99-8862-e6352077bea8")]
            public virtual RepoItemInfo SubmitInfo
            {
                get
                {
                    return _submitInfo;
                }
            }

            /// <summary>
            /// The KaasmetuiensausAthotmailCom item.
            /// </summary>
            [RepositoryItem("e2ac6fb2-51cb-4c13-8e65-3c1532d3759f")]
            public virtual Ranorex.ATag KaasmetuiensausAthotmailCom
            {
                get
                {
                    return _kaasmetuiensausathotmailcomInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The KaasmetuiensausAthotmailCom item info.
            /// </summary>
            [RepositoryItemInfo("e2ac6fb2-51cb-4c13-8e65-3c1532d3759f")]
            public virtual RepoItemInfo KaasmetuiensausAthotmailComInfo
            {
                get
                {
                    return _kaasmetuiensausathotmailcomInfo;
                }
            }

            /// <summary>
            /// The LogOut item.
            /// </summary>
            [RepositoryItem("795c761f-cb40-46a9-bc5f-1c46a9c1ec89")]
            public virtual Ranorex.ATag LogOut
            {
                get
                {
                    return _logoutInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The LogOut item info.
            /// </summary>
            [RepositoryItemInfo("795c761f-cb40-46a9-bc5f-1c46a9c1ec89")]
            public virtual RepoItemInfo LogOutInfo
            {
                get
                {
                    return _logoutInfo;
                }
            }

            /// <summary>
            /// The SmallSearchterms item.
            /// </summary>
            [RepositoryItem("f200793b-6911-4f6f-bbe6-33001e5cc962")]
            public virtual Ranorex.InputTag SmallSearchterms
            {
                get
                {
                    return _smallsearchtermsInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The SmallSearchterms item info.
            /// </summary>
            [RepositoryItemInfo("f200793b-6911-4f6f-bbe6-33001e5cc962")]
            public virtual RepoItemInfo SmallSearchtermsInfo
            {
                get
                {
                    return _smallsearchtermsInfo;
                }
            }

            /// <summary>
            /// The TheProductHasBeenAddedToYour item.
            /// </summary>
            [RepositoryItem("379ce825-b737-4699-83ca-c358762ba0e8")]
            public virtual Ranorex.PTag TheProductHasBeenAddedToYour
            {
                get
                {
                    return _theproducthasbeenaddedtoyourInfo.CreateAdapter<Ranorex.PTag>(true);
                }
            }

            /// <summary>
            /// The TheProductHasBeenAddedToYour item info.
            /// </summary>
            [RepositoryItemInfo("379ce825-b737-4699-83ca-c358762ba0e8")]
            public virtual RepoItemInfo TheProductHasBeenAddedToYourInfo
            {
                get
                {
                    return _theproducthasbeenaddedtoyourInfo;
                }
            }

            /// <summary>
            /// The ShoppingCart item.
            /// </summary>
            [RepositoryItem("e9d0e5fd-16e3-4475-952e-b8b6ea33028a")]
            public virtual Ranorex.SpanTag ShoppingCart
            {
                get
                {
                    return _shoppingcartInfo.CreateAdapter<Ranorex.SpanTag>(true);
                }
            }

            /// <summary>
            /// The ShoppingCart item info.
            /// </summary>
            [RepositoryItemInfo("e9d0e5fd-16e3-4475-952e-b8b6ea33028a")]
            public virtual RepoItemInfo ShoppingCartInfo
            {
                get
                {
                    return _shoppingcartInfo;
                }
            }

            /// <summary>
            /// The StrongTag40400 item.
            /// </summary>
            [RepositoryItem("76678ae3-7dd7-4b24-99cd-eeecbceb862f")]
            public virtual Ranorex.StrongTag StrongTag40400
            {
                get
                {
                    return _strongtag40400Info.CreateAdapter<Ranorex.StrongTag>(true);
                }
            }

            /// <summary>
            /// The StrongTag40400 item info.
            /// </summary>
            [RepositoryItemInfo("76678ae3-7dd7-4b24-99cd-eeecbceb862f")]
            public virtual RepoItemInfo StrongTag40400Info
            {
                get
                {
                    return _strongtag40400Info;
                }
            }

            /// <summary>
            /// The Smartphone item.
            /// </summary>
            [RepositoryItem("c034d8b4-b895-4719-a66b-e7308c61b5de")]
            public virtual Ranorex.ATag Smartphone
            {
                get
                {
                    return _smartphoneInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The Smartphone item info.
            /// </summary>
            [RepositoryItemInfo("c034d8b4-b895-4719-a66b-e7308c61b5de")]
            public virtual RepoItemInfo SmartphoneInfo
            {
                get
                {
                    return _smartphoneInfo;
                }
            }

            /// <summary>
            /// The BlueJeans item.
            /// </summary>
            [RepositoryItem("54478cbf-d3c1-46b4-80d4-b9e055278495")]
            public virtual Ranorex.ATag BlueJeans
            {
                get
                {
                    return _bluejeansInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The BlueJeans item info.
            /// </summary>
            [RepositoryItemInfo("54478cbf-d3c1-46b4-80d4-b9e055278495")]
            public virtual RepoItemInfo BlueJeansInfo
            {
                get
                {
                    return _bluejeansInfo;
                }
            }

            /// <summary>
            /// The Updatecart item.
            /// </summary>
            [RepositoryItem("e153eca8-ea1a-4136-b51e-50c27213f99e")]
            public virtual Ranorex.InputTag Updatecart
            {
                get
                {
                    return _updatecartInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Updatecart item info.
            /// </summary>
            [RepositoryItemInfo("e153eca8-ea1a-4136-b51e-50c27213f99e")]
            public virtual RepoItemInfo UpdatecartInfo
            {
                get
                {
                    return _updatecartInfo;
                }
            }

            /// <summary>
            /// The DivTagYourShoppingCartIsE item.
            /// </summary>
            [RepositoryItem("005a2bc6-6895-4abe-840d-295b2df09f2d")]
            public virtual Ranorex.DivTag DivTagYourShoppingCartIsE
            {
                get
                {
                    return _divtagyourshoppingcartiseInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The DivTagYourShoppingCartIsE item info.
            /// </summary>
            [RepositoryItemInfo("005a2bc6-6895-4abe-840d-295b2df09f2d")]
            public virtual RepoItemInfo DivTagYourShoppingCartIsEInfo
            {
                get
                {
                    return _divtagyourshoppingcartiseInfo;
                }
            }

            /// <summary>
            /// The FooterMenuWrapper item.
            /// </summary>
            [RepositoryItem("8c604974-0e0d-45d9-8fa1-ea5a057ad6a2")]
            public virtual Ranorex.DivTag FooterMenuWrapper
            {
                get
                {
                    return _footermenuwrapperInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The FooterMenuWrapper item info.
            /// </summary>
            [RepositoryItemInfo("8c604974-0e0d-45d9-8fa1-ea5a057ad6a2")]
            public virtual RepoItemInfo FooterMenuWrapperInfo
            {
                get
                {
                    return _footermenuwrapperInfo;
                }
            }

            /// <summary>
            /// The Removefromcart item.
            /// </summary>
            [RepositoryItem("fb6e1501-b455-4907-a0be-a09d78a776db")]
            public virtual Ranorex.InputTag Removefromcart
            {
                get
                {
                    return _removefromcartInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Removefromcart item info.
            /// </summary>
            [RepositoryItemInfo("fb6e1501-b455-4907-a0be-a09d78a776db")]
            public virtual RepoItemInfo RemovefromcartInfo
            {
                get
                {
                    return _removefromcartInfo;
                }
            }

            /// <summary>
            /// The Removefromcart1 item.
            /// </summary>
            [RepositoryItem("c5afb92f-0e5d-485c-b165-cdfb39e0ff71")]
            public virtual Ranorex.InputTag Removefromcart1
            {
                get
                {
                    return _removefromcart1Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Removefromcart1 item info.
            /// </summary>
            [RepositoryItemInfo("c5afb92f-0e5d-485c-b165-cdfb39e0ff71")]
            public virtual RepoItemInfo Removefromcart1Info
            {
                get
                {
                    return _removefromcart1Info;
                }
            }

            /// <summary>
            /// The H1TagSm item.
            /// </summary>
            [RepositoryItem("c9ff4683-e1a4-4783-86b6-2a410aa41a8b")]
            public virtual Ranorex.H1Tag H1TagSm
            {
                get
                {
                    return _h1tagsmInfo.CreateAdapter<Ranorex.H1Tag>(true);
                }
            }

            /// <summary>
            /// The H1TagSm item info.
            /// </summary>
            [RepositoryItemInfo("c9ff4683-e1a4-4783-86b6-2a410aa41a8b")]
            public virtual RepoItemInfo H1TagSmInfo
            {
                get
                {
                    return _h1tagsmInfo;
                }
            }

            /// <summary>
            /// The AddToCart folder.
            /// </summary>
            [RepositoryFolder("b236900a-b1b7-4629-9a26-8cd640bebf58")]
            public virtual DemoWebshopRepositoryFolders.AddToCartFolder AddToCart
            {
                get { return _addtocart; }
            }
        }

        /// <summary>
        /// The AddToCartFolder folder.
        /// </summary>
        [RepositoryFolder("b236900a-b1b7-4629-9a26-8cd640bebf58")]
        public partial class AddToCartFolder : RepoGenBaseFolder
        {
            RepoItemInfo _addtocart36enteredquantityInfo;
            RepoItemInfo _addtocart43enteredquantityInfo;
            RepoItemInfo _buttonInfo;

            /// <summary>
            /// Creates a new AddToCart  folder.
            /// </summary>
            public AddToCartFolder(RepoGenBaseFolder parentFolder) :
                    base("AddToCart", ".//form[#'product-details-form']/div/div[1]/div[2]/div[6]", parentFolder, 30000, null, false, "b236900a-b1b7-4629-9a26-8cd640bebf58", "")
            {
                _addtocart36enteredquantityInfo = new RepoItemInfo(this, "Addtocart36EnteredQuantity", "?/?/input[@name='addtocart_36.EnteredQuantity']", 30000, null, "00ab6878-8409-4489-8739-7d41d2eccd01");
                _addtocart43enteredquantityInfo = new RepoItemInfo(this, "Addtocart43EnteredQuantity", "?/?/input[@name='addtocart_43.EnteredQuantity']", 30000, null, "8c973260-1de0-4fd8-8420-d61ca8074709");
                _buttonInfo = new RepoItemInfo(this, "Button", "?/?/input[@value='Add to cart']", 30000, null, "01a85455-1893-4f0d-a1c2-55c47d9d6b04");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("b236900a-b1b7-4629-9a26-8cd640bebf58")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("b236900a-b1b7-4629-9a26-8cd640bebf58")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Addtocart36EnteredQuantity item.
            /// </summary>
            [RepositoryItem("00ab6878-8409-4489-8739-7d41d2eccd01")]
            public virtual Ranorex.InputTag Addtocart36EnteredQuantity
            {
                get
                {
                    return _addtocart36enteredquantityInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Addtocart36EnteredQuantity item info.
            /// </summary>
            [RepositoryItemInfo("00ab6878-8409-4489-8739-7d41d2eccd01")]
            public virtual RepoItemInfo Addtocart36EnteredQuantityInfo
            {
                get
                {
                    return _addtocart36enteredquantityInfo;
                }
            }

            /// <summary>
            /// The Addtocart43EnteredQuantity item.
            /// </summary>
            [RepositoryItem("8c973260-1de0-4fd8-8420-d61ca8074709")]
            public virtual Ranorex.InputTag Addtocart43EnteredQuantity
            {
                get
                {
                    return _addtocart43enteredquantityInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Addtocart43EnteredQuantity item info.
            /// </summary>
            [RepositoryItemInfo("8c973260-1de0-4fd8-8420-d61ca8074709")]
            public virtual RepoItemInfo Addtocart43EnteredQuantityInfo
            {
                get
                {
                    return _addtocart43enteredquantityInfo;
                }
            }

            /// <summary>
            /// The Button item.
            /// </summary>
            [RepositoryItem("01a85455-1893-4f0d-a1c2-55c47d9d6b04")]
            public virtual Ranorex.InputTag Button
            {
                get
                {
                    return _buttonInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Button item info.
            /// </summary>
            [RepositoryItemInfo("01a85455-1893-4f0d-a1c2-55c47d9d6b04")]
            public virtual RepoItemInfo ButtonInfo
            {
                get
                {
                    return _buttonInfo;
                }
            }
        }

        /// <summary>
        /// The DemoWebShopGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("d7955e27-6d1f-4a16-978b-bb738c048555")]
        public partial class DemoWebShopGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _paneInfo;
            RepoItemInfo _pane1Info;

            /// <summary>
            /// Creates a new DemoWebShopGoogleChrome  folder.
            /// </summary>
            public DemoWebShopGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("DemoWebShopGoogleChrome", "/form[@title>'Demo Web Shop - Google Ch']", parentFolder, 30000, null, true, "d7955e27-6d1f-4a16-978b-bb738c048555", "")
            {
                _paneInfo = new RepoItemInfo(this, "Pane", "container[@accessiblename>'Demo Web Shop - Google Chrome']/container/container[1]", 30000, null, "92cc01ae-b162-46c8-b70b-30c6da468479");
                _pane1Info = new RepoItemInfo(this, "Pane1", "container[@accessiblename>'Demo Web Shop. Login - Google']/container/container[1]", 30000, null, "b7fb66c7-ddd5-4bbd-8e28-adaacc365bb1");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d7955e27-6d1f-4a16-978b-bb738c048555")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d7955e27-6d1f-4a16-978b-bb738c048555")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Pane item.
            /// </summary>
            [RepositoryItem("92cc01ae-b162-46c8-b70b-30c6da468479")]
            public virtual Ranorex.Container Pane
            {
                get
                {
                    return _paneInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Pane item info.
            /// </summary>
            [RepositoryItemInfo("92cc01ae-b162-46c8-b70b-30c6da468479")]
            public virtual RepoItemInfo PaneInfo
            {
                get
                {
                    return _paneInfo;
                }
            }

            /// <summary>
            /// The Pane1 item.
            /// </summary>
            [RepositoryItem("b7fb66c7-ddd5-4bbd-8e28-adaacc365bb1")]
            public virtual Ranorex.Container Pane1
            {
                get
                {
                    return _pane1Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Pane1 item info.
            /// </summary>
            [RepositoryItemInfo("b7fb66c7-ddd5-4bbd-8e28-adaacc365bb1")]
            public virtual RepoItemInfo Pane1Info
            {
                get
                {
                    return _pane1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
