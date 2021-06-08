using System;
using Ex_199.Entities;

namespace Ex_199.Services {
    class ContractProcess {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractProcess(IOnlinePaymentService onlinePaymentService) {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months) {
            double parcel = contract.TotalValue / months;
            DateTime date = contract.Date;

            for (int i=1; i <= months; i++) {
                double IParcel = parcel + _onlinePaymentService.Interest(parcel, i);
                double FParcel = IParcel + _onlinePaymentService.PaymentFee(IParcel);
                DateTime parcelMonth = date.AddMonths(i);
                contract.Installments.Add(new Installment(parcelMonth, FParcel));
            }
        }
    }
}
