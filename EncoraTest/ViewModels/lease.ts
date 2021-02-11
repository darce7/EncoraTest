import { LeaseSummary } from './leaseSummary'
import { UtilitiesOwnership } from './utilitiesOwnership'
import { ApplianceOwnership } from './applianceOwnership'

export interface Lease {
    leaseSummary: LeaseSummary;
    utilitiesOwnership: UtilitiesOwnership;
    applianceOwnership: ApplianceOwnership;
}