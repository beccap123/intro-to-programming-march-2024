
// tell typescript about the "application state" - what it looks like
 
import { ActionReducerMap } from "@ngrx/store";
 
export interface ApplicationState {}

// then I'm going to tell Ngrx Store that this is what the state IS
 
export const reducers:ActionReducerMap<ApplicationState> = {};