using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HazeltreeAngular.Models
{
    internal class Securities : ISecurities
    {

        private List<Security> _list = new List<Security>();

        public  Securities()
        {
            _list.Add(new Security { SecurityId = 1
                                    ,SecurityCode = "YHOO"
                                    ,SecurityName = "Yahoo"
                                    ,Sedol = "1111234"
                                    ,Cusip = "459200-10-1"
                                    ,Isin = "123123456123"
                                    });
            _list.Add(new Security { SecurityId = 2
                                    ,SecurityCode = "MSFT"
                                    ,SecurityName = "Microsoft"
                                    ,Sedol = "2224567"
                                    ,Cusip = "459198-10-1"
                                    ,Isin = "1"
                                    });
            _list.Add(new Security { SecurityId = 3
                                    ,SecurityCode = "AAPL"
                                    ,SecurityName = "Apple"
                                    ,Sedol = "3337890"
                                    ,Cusip = "459184-10-1"
                                    ,Isin = "123123456125"
                                    });  
            _list.Add(new Security { SecurityId = 2
                                    ,SecurityCode = "GOOGL"
                                    ,SecurityName = "Google"
                                    ,Sedol = "4446756"
                                    ,Cusip = "459555-10-1"
                                    ,Isin = ""
                                    });           
        }

 




         IList<Security> ISecurities.Search(string SecurityCode, string SearchText)
        {
            var result = _list.Where(p => p.SecurityCode.ToUpper() == SecurityCode.ToUpper() || p.SecurityName.ToUpper() == SearchText.ToUpper());
            return result.ToList();
        }
    }
}