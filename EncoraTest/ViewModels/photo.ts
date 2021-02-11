export interface Photo {
    id: number;
    guid: string;
    resourceType: string;
    isPublic: boolean;
    description: string;
    fileName: string;
    sizeInByte: number;
    contentType: string;
    url: string;
    urlMedium: string;
    urlSmall: string;
    textContent: string;
}