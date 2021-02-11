export interface LeaseSummary {
    occupancy: string;
    leasingStatus: string;
    marketedRent: string;
    paymentStatus: string;
    leaseStartDate: string;
    leaseEndDate: string;
    monthlyRent: number;
    securityDepositAmount: number;
    isPetsDeposit: boolean;
    petsDepositAmount: number;
    isLeaseConcessions: boolean;
    isRentersInsuranceRequired: boolean;
    isSection8: boolean;
    isTenantBackgroudChecked: boolean;
    isTenantIncomeAbove3x: boolean;
    isTenantMayTerminateEarly: boolean;
    isTenantPurchaseOption: boolean;
}