using PizzaApp.Forms;

namespace PizzaApp
{
    public class WindowsManagement
    {
        public static MainWindow mainWindow;
        public static OrderWindow orderWindow;
        public static OrderConfirm orderConfirm;
        public static HistoryWindow historyWindow;
        public static ExtrasPanel extrasPanel;
        public static ShoppingCart shopCart;


        public static MainWindow GetMainWindowInstance()
        {
            if (mainWindow == null || mainWindow.IsDisposed)
            {
                mainWindow = new MainWindow();
            }
            return mainWindow;
        }

        public static OrderWindow GetOrderWindowInstance()
        {
            if (orderWindow == null || orderWindow.IsDisposed)
            {
                orderWindow = new OrderWindow();
            }
            return orderWindow;
        }

        public static OrderConfirm GetOrderConfirmInstance()
        {
            if (orderConfirm == null || orderConfirm.IsDisposed)
            {
                orderConfirm = new OrderConfirm();
            }
            return orderConfirm;
        }  

        public static HistoryWindow GetHistoryWindowInstance()
        {
            if (historyWindow == null || historyWindow.IsDisposed)
            {
                historyWindow = new HistoryWindow();
            }
            return historyWindow;
        }

        public static ExtrasPanel GetExtrasPanelInstance()
        {
            if (extrasPanel == null || extrasPanel.IsDisposed)
            {
                extrasPanel = new ExtrasPanel();
            }
            return extrasPanel;
        }

        public static ShoppingCart GetShopCartInstance()
        {
            if (shopCart == null || shopCart.IsDisposed)
            {
                shopCart = new ShoppingCart();
            }
            return shopCart;
        }
    }
}
