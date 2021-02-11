import { Photo } from './photo'
import { ThreeDRendering } from './threeDRendering'
import { Audio } from './audio'

export interface Resource {
    photos: Photo[];
    floorPlans: Photo[];
    threeDRenderings: ThreeDRendering[];
    audios: Audio[];
}