export * from './shiftAPI.service';
import { ShiftAPIService } from './shiftAPI.service';
export * from './taskAPI.service';
import { TaskAPIService } from './taskAPI.service';
export const APIS = [ShiftAPIService, TaskAPIService];
