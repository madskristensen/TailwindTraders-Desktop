using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using CouponReader.Common.Models;

namespace CouponReader.Common.Services
{
    public class CouponsService
    {
        public IEnumerable<CouponHistory> GetRecentValidHistory()
        {
            var isValid = GetIsCouponHistoryValid();

            if (isValid)
            {
                return CouponHistory.Where(c => c.Date > DateTime.UtcNow.AddDays(30));
            }

            return Enumerable.Empty<CouponHistory>();
        }

        public List<CouponHistory> CouponHistory
        {
            get
            {
                var history = new List<CouponHistory>
                {
                    new CouponHistory()
                    {
                        Date = DateTime.Now.AddMinutes(30).AddDays(20),
                        Coupon = Coupons[0]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.Now.AddMinutes(25).AddDays(19),
                        Coupon = Coupons[1]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(18).AddMinutes(15),
                        Coupon = Coupons[2]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.Now.AddMinutes(45).AddDays(17),
                        Coupon = Coupons[3]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.Now.AddMinutes(50).AddDays(16),
                        Coupon = Coupons[4]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(15).AddMinutes(30),
                        Coupon = Coupons[0]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(14).AddMinutes(25),
                        Coupon = Coupons[1]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(13).AddMinutes(15),
                        Coupon = Coupons[2]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(12).AddMinutes(45),
                        Coupon = Coupons[3]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(11).AddMinutes(50),
                        Coupon = Coupons[4]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(10).AddMinutes(30),
                        Coupon = Coupons[0]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(9).AddMinutes(25),
                        Coupon = Coupons[1]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(8).AddMinutes(15),
                        Coupon = Coupons[2]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(7).AddMinutes(45),
                        Coupon = Coupons[3]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(6).AddMinutes(50),
                        Coupon = Coupons[4]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(5).AddMinutes(50),
                        Coupon = Coupons[4]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(4).AddMinutes(50),
                        Coupon = Coupons[0]
                    },
                    
                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(3).AddMinutes(50),
                        Coupon = Coupons[1]
                    },
                    
                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(2).AddMinutes(50),
                        Coupon = Coupons[2]
                    },

                    new CouponHistory()
                    {
                        Date = DateTime.UtcNow.AddDays(1).AddMinutes(50),
                        Coupon = Coupons[3]
                    }
                };
                return history;
            }
        }

        private static CouponsService instance;

        public static CouponsService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CouponsService();
                }

                return instance;
            }
        }

        public List<Coupon> Coupons
        {
            get
            {
                return new List<Coupon>
                {
                    new Coupon()
                    {
                        ExternalId = new Guid("09fb6ed0-7998-4111-ad6c-dfbb39b1a3cf"),
                        Code = "Code10",
                        CouponText = "10& Off power tools",
                        Redeemed = false,
                        User = "Annick B. Addison",
                        UserName = "cbaddison1",
                        ImageUrl = "https://tailwindtraders.blob.core.windows.net/desktop/Coupon_1.png",
                        Expiration = DateTime.Now.AddYears(2)
                    },

                    new Coupon()
                    {
                        ExternalId = new Guid("08fb6ed0-7998-4111-ad6c-dfbb39b1a3cf"),
                        Code = "Code50",
                        CouponText = "50% Off on pipelines",
                        Redeemed = true,
                        User = "Mathew Y. Rosendahl",
                        UserName = "lusi_123",
                        ImageUrl = "https://tailwindtraders.blob.core.windows.net/desktop/Coupon_2.png",
                        Expiration = DateTime.Now.AddYears(2).AddHours(7)
                    },

                    new Coupon()
                    {
                        ExternalId = new Guid("56c8369f-d0e9-4df9-8458-f4d4d074b1ec"),
                        Code = "Code20D",
                        CouponText = "$20 Off for your Appliances",
                        Redeemed = true,
                        User = "Gillian Carter",
                        UserName = "thecarter",
                        ImageUrl = "https://tailwindtraders.blob.core.windows.net/desktop/Coupon_3.png",
                        Expiration = DateTime.Now.AddYears(2).AddHours(6)
                    },

                    new Coupon()
                    {
                        ExternalId = new Guid("6ba26946-9ed5-4510-9a8b-0bb955f67a02"),
                        Code = "Code20P",
                        CouponText = "20% Off on bathroom",
                        Redeemed = true,
                        User = "Jack Bains",
                        UserName = "bains_12345",
                        ImageUrl = "https://tailwindtraders.blob.core.windows.net/desktop/Coupon_4.png",
                        Expiration = DateTime.Now.AddYears(2)
                    },

                    new Coupon()
                    {
                        ExternalId = new Guid("88a009c4-19c3-438d-9ec1-944dbf22e858"),
                        Code = "Code20D2",
                        CouponText = "$20 Off for your next purchase",
                        Redeemed = true,
                        User = "Javier Suárez",
                        UserName = "jsuarez",
                        ImageUrl = "https://tailwindtraders.blob.core.windows.net/desktop/Coupon_5.png",
                        Expiration = DateTime.Now.AddYears(2).AddHours(5)
                    }
                };
            }
        }

        public bool GetIsCouponHistoryValid()
        {
            return true;
        }

        public Coupon FindCouponByCode(string code)
        {
            var isValid = GetIsCouponHistoryValid();
            // TODO: Live Unit Testing
            return Coupons.FirstOrDefault(x => x.Code.Equals(code, StringComparison.InvariantCultureIgnoreCase));
        }

        public void RedeemedCoupon(string code)
        {
            var coupon = FindCouponByCode(code);

            coupon.Redeemed = true;
        }
    }
}