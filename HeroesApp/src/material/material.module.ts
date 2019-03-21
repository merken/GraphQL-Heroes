import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import {
    MatButtonModule,
    MatCardModule,
    MatDialogModule,
    MatIconModule,
    MatMenuModule,
    MatToolbarModule,
    MatTableModule,
    MatSort,
    MatSortModule,
    MatInputModule,
    MatProgressSpinnerModule,
    MatRadioGroup,
    MatRadioButton,
    MatRadioModule,
    MatCheckboxModule,
    MatListModule
} from '@angular/material';

@NgModule({
    imports: [
        MatCardModule,
        MatButtonModule,
        MatMenuModule,
        MatToolbarModule,
        MatIconModule,
        MatCardModule,
        MatDialogModule,
        MatTableModule,
        MatSortModule,
        MatInputModule,
        MatProgressSpinnerModule,
        MatRadioModule,
        MatCheckboxModule,
        BrowserAnimationsModule,
        MatListModule

    ],
    exports: [
        MatCardModule,
        MatButtonModule,
        MatMenuModule,
        MatToolbarModule,
        MatIconModule,
        MatCardModule,
        MatDialogModule,
        MatTableModule,
        MatSortModule,
        MatInputModule,
        MatProgressSpinnerModule,
        MatRadioModule,
        MatCheckboxModule,
        BrowserAnimationsModule,
        MatListModule

    ],
})
// This module contains all the material imports
export class MaterialModule { }
