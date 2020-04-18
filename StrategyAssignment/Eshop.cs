using System;
using System.Collections.Generic;

namespace StrategyAssignment
{
    public class Eshop
    {
        private PaymentMethod _paymentMethod;
        private IEnumerable<Variation> _variations;

        //Set because All 3 variations must be included to get the total Tshirt Cost
        public void SetVariationStrategy(List<Variation> variations)
        {
            _variations = variations;
        }

        //Select between 3 Payment Methods and assing it to _paymentMethod field
        public void SelectPaymentMethod(int paymentInput)
        {
            switch (paymentInput)
            {
                case 1:
                    _paymentMethod = new CreditCard();
                    break;
                case 2:
                    _paymentMethod = new BankTransfer();
                    break;
                default:
                    _paymentMethod = new Cash();
                    break;
            }
        }
        public void PayTShirt(TShirt tshirt)
        {
            foreach (var variation in _variations)
            {
                Console.WriteLine($"Applying {variation.GetType().Name}");
                variation.Cost(tshirt);
                Console.WriteLine($"TShirt cost after applying {variation.GetType().Name} is: {tshirt.Price}");
            }
            _paymentMethod.Pay(tshirt.Price);
        }
        public static void EshopDemo()
        {
            List<Variation> variations = new List<Variation>()
            {
                new ColorVariation(),
                new SizeVariation(),
                new FabricVariation()
            };

            Console.WriteLine("Hello,What tshirt color u want?");
            var colorInput = Console.ReadLine().Trim().ToUpper();
            var color = SetColor(colorInput);

            Console.WriteLine("How about Size?");
            var sizeInput = Console.ReadLine().Trim().ToUpper();
            var size = SetSize(sizeInput);

            Console.WriteLine("Material?");
            var fabricInput = Console.ReadLine().Trim().ToUpper();
            var fabric = SetFabric(fabricInput);

            Console.WriteLine("Choose Payment Method 1) Credit Card 2) Cash 3) Bank Transfer");
            var paymentInput = Convert.ToInt32(Console.ReadLine().Trim());
            var tShirt = new TShirt(color, size, fabric);
            var eshop = new Eshop();

            eshop.SetVariationStrategy(variations);
            eshop.SelectPaymentMethod(paymentInput);
            eshop.PayTShirt(tShirt);
        }

        public static Color SetColor(string colorInput)
        {
            switch (colorInput)
            {
                case "RED":
                    return Color.RED;
                case "ORANGE":
                    return Color.ORANGE;
                case "YELLOW":
                    return Color.ORANGE;
                case "GREEN":
                    return Color.GREEN;
                case "BLUE":
                    return Color.BLUE;
                case "INDIGO":
                    return Color.INDIGO;
                default:
                    return Color.VIOLET;
            }
        }
        public static Size SetSize(string sizeInput)
        {
            switch (sizeInput)
            {
                case "XS":
                    return Size.XS;
                case "S":
                    return Size.S;
                case "M":
                    return Size.M;
                case "L":
                    return Size.L;
                case "XL":
                    return Size.XL;
                case "XXL":
                    return Size.XXL;
                case "XXXL":
                    return Size.XXXL;
                default:
                    return Size.M;
            }
        }
        public static Fabric SetFabric(string fabricInput)
        {
            switch (fabricInput)
            {
                case "WOOL":
                    return Fabric.WOOL;
                case "COTTON":
                    return Fabric.COTTON;
                case "POLYESTER":
                    return Fabric.POLYESTER;
                case "RAYON":
                    return Fabric.RAYON;
                case "LINEN":
                    return Fabric.LINEN;
                case "CASHMERE":
                    return Fabric.CASHMERE;
                default:
                    return Fabric.SILK;
            }
        }
    }
}
