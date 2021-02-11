import { Address } from './address'
import { Financial } from './financial'
import { Physical } from './physical'
import { Score } from './score'
import { Valuation } from './valuation'
import { Resource } from './resource'
import { Lease } from './lease'
import { Diligence } from './diligence'
import { GoogleMapOption } from './googleMapOption'

export interface Property {
    id: number;
    accountId: number;
    buyerAccountId: number;
    externalId: number;
    programId: number;
    isDwellCertified: boolean;
    isAllowOffer: boolean;
    isAllowPreview: boolean;
    isFeature: boolean;
    isRentGuaranteed: boolean;
    allowRentGuaranteedOptout: boolean;
    isSecuritized: boolean;
    isHot: boolean;
    isNew: boolean;
    isBargain: boolean;
    isDiligenceVaultUnlocked: boolean;
    isPropertyManagerOfferRetain: boolean;
    isHoa: boolean;
    hasAudio: boolean;
    hasDiligenceVaultDocuments: boolean;
    marketId: number;
    daysOnMarket: number;
    latitude: number;
    longitude: number;
    name: string;
    description: string;
    highlights: string;
    mainImageUrl: string;
    personalProperties: string;
    diligenceVaultSummary: string;
    featuredReason: string;
    status: string;
    allowedFundingTypes: string;
    allowableSaleTypes: string;
    visibility: string;
    priceVisibility: string;
    type: string;
    certificationLevel: string;
    escrowClosingDate: string;
    address: Address;
    financial: Financial;
    physical: Physical;
    score: Score;
    valuation: Valuation;
    resource: Resource;
    manager: string;
    seller: string;
    sellerBroker: string;
    hoa: string;
    lease: Lease;
    diligences: Diligence[];
    googleMapOption: GoogleMapOption;
    inspectionType: string;
}