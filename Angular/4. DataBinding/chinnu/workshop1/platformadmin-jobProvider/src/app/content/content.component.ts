import { Component } from '@angular/core';
import { Company } from '../jobproviderlist';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent {
  company: Company[];
  filteredCompany :Company[];
  constructor() {
    this.company = [
      {
        companyName: "Funk Inc.",
        jobRole: "IT Department",
        image: "assets/images/contact.png"
      },
      {
        companyName: "Aitrich Ltd.",
        jobRole: "IT Department",
         image: "assets/images/email.png"

      },
      {
        companyName: "Highspeed Studios",
        jobRole: "Creative Design Agency",
         image: "assets/images/filter 1.png"
      },
      {
        companyName: "Mosciski Inc.",
        jobRole: "Creative Design Agency",
         image: "assets/images/Group.png"
      },
      {
        companyName: "Incubator Studios",
        jobRole: "Software House",
         image: "assets/images/Frame 2.png"
      },
      {
        companyName: "Naonotu Inc.",
        jobRole: "Creative Design Agency",
         image: "assets/images/background.png"
      },
      {
        companyName: "ColoColo Studios",
        jobRole: "Internet Service Porvider",
         image: "assets/images/image 3.png"
      },
      {
       companyName: "Funk Inc.",
        jobRole: "IT Department",
         image: "assets/images/image 5.png"
      },
      {
        companyName: "Mosciski Inc.",
        jobRole: "Creative Design Agency",
         image: "assets/images/image 6.png"
      },
      {
        companyName: "Highspeed Studios",
        jobRole: "Creative Design Agency",
         image: "assets/images/image 7.png"
      },
      {
        companyName: "Simonis Ltd",
        jobRole: "Internet Service Porvider",
         image: "assets/images/image 8.png"
      },
      {
        companyName: "Funk Inc.",
        jobRole: "IT Department",
         image: "assets/images/image 9.png"
      },
    ];

    this.filteredCompany = this.company;
  }

  filterJobs(event: Event): void {
    const searchTerm = (event.target as HTMLInputElement).value;
    this.filteredCompany = this.company.filter(company =>
      company.companyName.toLowerCase().includes(searchTerm.toLowerCase()) ||
      company.jobRole.toLowerCase().includes(searchTerm.toLowerCase())
    );
  }

  isHovered: boolean = false;

}



