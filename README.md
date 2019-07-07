## NetworkTest
A C# GUI Program to test network connections and other system information
#### Author
Ian Stroszeck
#### Portions of Program
1. Show System Information about PC
  - Hostname
  - Domain (if applicable)
  - IP address
  - MAC address
  - Hardware Information
2. Test that PC can ping gateway of network
3. Test that PC can ping 1.1.1.1 (off LAN)
4. Test that DNS works by pinging example.com
5. After all 3 tests have finished:
  - If all tests succeeded, show one big green checkbox with nice message
  - If any or all tests failed, show appropriate message on possible solution
    - Show each test (pass/fail) if anything failed
### Flowchart (v1.0)

![Flowchartv1.0](https://github.com/catmeum/NetworkTest/blob/master/Panes_for_wireframe/Network_Testing_Flowchart_v1.0.png)
### TO-DO:
1. Create Icons
  - [x] Green Check circle
  - [x] Red X circle
  - [x] Grey circle outline
  - [ ] Pulsing blue progress icon
2. Wireframing
  - [x] Add in icons (or stand-ins)
  - [x] Create Lucidchart Flowchart v1.0 and add to GitHub
  - [x] Show results page
  - [ ] BONUS - Add in extra pages to help fix specific network issues
  	- Auto run console commands (flush DNS, etc.)
3. Setup project in C# Visual Studio
  - [ ] Create git ignore file
  - [ ] Create basic design in C#
  - [ ] Name elements
4. Backend 
  - [ ] Research how to get computer info for start screen
  - [ ] Research how to run OS commands from C#
5. Other

