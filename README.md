# ZooAndAnimalFun


Week 11

<img width="789" height="332" alt="SessionModel" src="https://github.com/user-attachments/assets/a001d952-7166-4d52-8e16-2b80d38015a0" />
<img width="528" height="592" alt="SessionIndex" src="https://github.com/user-attachments/assets/45b62982-faa4-4b73-a17c-34d3f7ca9590" />
<img width="540" height="194" alt="SessionDBInformation" src="https://github.com/user-attachments/assets/0a666565-4694-4b44-ba27-6c1a5a6a390b" />

I don't have the service class so I will do my best to explain why it hasn't been necessary by the use of the parts that I will be showing in the pictures and what I will have written down. My test plan involved seeing if I could check if the time was available, so I ended up using the 3 parts of my session to determine that. One of the parts is from the seed.xml, this is where the information is to be held. This will then be utilized to pick up the other models IDs and there for its information due to the fact that all the information being used in this model is purely dependent on the other models information, the use of the Session model to determine what information I will need to be a part of the that part of database to able to determine what to pull out from the other models database and the sessions index is the part of the website that will display the gathered information to show the of the events name, the venue in use, and the start and end times that come along with the event via the event that would determine what times are available for that day. 



Week 12

<img width="524" height="691" alt="CRUDGet" src="https://github.com/user-attachments/assets/06389f27-5b04-4b96-820e-55126acf963c" />
<img width="988" height="833" alt="CRUDEdit" src="https://github.com/user-attachments/assets/91a4b258-9209-49f5-a3f5-066491547013" />
<img width="512" height="357" alt="CRUDDelete" src="https://github.com/user-attachments/assets/3552e825-5c1a-4aa3-bd21-fa9b517f3c48" />
<img width="896" height="509" alt="CRUDCreate" src="https://github.com/user-attachments/assets/4b6d7315-15ef-419e-a3ef-c9a84800ff98" />
<img width="788" height="842" alt="MFP" src="https://github.com/user-attachments/assets/cfb865a7-5dae-4b5d-ad5c-32ec48cc3df0" />

As you can see under model, I have bracket with words like Key, Required, and RegularExpression. Thoose are the restrictions I have placed on them to affect the range of information more than the type of information I will be using (int, string, double, etc.). Since that a majority of the contain has the [Required] bracket above it this will mean to that the value will be needed, and I will not be able to create a new row of information without it. For instance, I require the GenderID so I will be able to pull up and take the gender from the gender model.


In the controller section I implemented the async data access part of the requirement for the assignment. It is currently split up into the different sections of the view, the creation, deletion, editing, and index parts. These sections are also split up into 3 different parts as well, one will be .FirstOrDefaultAsync(), second part will be .FindAsync(), and third and last part of it will be the SaveChangesAsync().  Each one will be applied at different points in the process to apply depending on which part of the view you are using but as a simple run down it be with FirstOrDefault it grabs the information that is in line with what you are asking, with .FindAsync() it will grab the primary key currently uses for the information, and with .SaveChangesAsync() it will apply any changes made from changes in information under the edit to getting rid of the information by deleting it. 



Week 13



