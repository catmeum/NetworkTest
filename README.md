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
