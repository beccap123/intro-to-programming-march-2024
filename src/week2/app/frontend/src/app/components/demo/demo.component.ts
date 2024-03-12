import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-demo',
  standalone: true,
  imports: [],
  template: `
    <p>
      {{ counter() }}
    </p>
    <button (click)="doIt()" class="btn btn-primary">Increment</button>
  `,
  styles: ``,
})
export class DemoComponent {
  counter = signal(0);

  doIt() {
    this.counter.set(this.counter() + 1);
  }
}
