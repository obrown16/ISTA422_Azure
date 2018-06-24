## Oscar Brown
## 6/5/2018
## Read chapter 5, pages 133 – 156 in the Fundamentals of Azure, 2nd Edition book

1. What is a VNET and what is it used for in Azure? 
They are used to provide private connectivity for Azure Virtual Machines (Azure VMs) and some Azure services. VMs and services that are part of the same virtual network can access one another.

2. The fully managed service in Azure that is used for cross-premises connectivity, is called what? The fully managed service in Azure that is used for cross-premises connectivity is called Virtual Network Gateway.

3. List three things you need to know when setting up a virtual network.
 Space, subnets, and DNS servers that you want to use.
 
4. What is the primary purpose of establishing a subnet? 
It is to break up your network into more manageable sections.

5. When in the deployment process of multiple Virtual Machines(VMs) are the VMs assigned their IP address? 
The VMs are assigned their IP address as they boot up.

6. Why should you set the location of the Resource Group? 
It’s best to specify the same Azure region that will be used for the resources when they are created.

7. What are the four rules to editing a template to redeploy? 
If you remove a resource from the template that is not in the resource group, that resource will be unchanged. If you add a resource to the template that is not in the resource group, it will create that resource for you when you redeploy the template. Resources that are unchanged but are still in the template will be ignored. Resources that are changed and still in the template will be updated.

8. Why should you not request a complete deployment using PowerShell? 
You may accidentally remove a section of your template with no way to recover it.

9. Why did Microsoft create NSGs? 
To provide a flexible method for defining the access rules allowing traffic into and out of a VM in a VNet

10. What is a VPN according to the book? 
It is an Azure managed service that is deployed into a VNet and provides the endpoint for VPN connectivity for point-to-site VPNs, site-to-site VPNs, and ExpressRoute