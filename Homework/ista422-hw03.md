## Oscar Brown
## 4/30/2018
## Read chapter 3, pages 70 – 100 in the Fundamentals of Azure, 2nd Edition book

1. What is Azure Virtual Machines and the terminology used in the chapter to reference? Supports development of virtual machines in Azure. You have total control and are responsible for installation, config, maintenance, and OS patches.

2. How do you stop an Azure VM, and give an example? 
Stop-AzureRmVM PowerShell cmdlet./ Stop-AzureRmVM -Name "AzEssentialDev3" -ResourceGroup "AzureEssentials" -StayProvisioned

3. What are three main resource providers used when working with Azure Virtual Machines, Storage, and Compute? 
Microsoft.Network, Microsoft.Storage, Microsoft.Compute

4. Where are durable disks stored and what are the benefits? 
They are backed by page blobs in Azure Storage. The disks inherit the benefits of blob storage: high availability. The benefits are high availability, durability, and geo redundancy.

5. What is required when creating a VM in Azure using the Resource Manager model? 
VM must be within an Azure Virtual Network

6. What is a NIC and what does it what does it do for Azure? 
Network interface cards provide network access to resources in an Azure virtual network.

7. Why should you deploy at least two instances of the VM? What is provided? 
To avoid a single point of failure. Azure provides an SLA only when two or more VMs are deployed into an availability set.

8. How many ways can you connect to your VM, and what are they? 
Remote accessing the VM for an interactive session or by configuring network access

9. Who’s responsibility is it to manage the VM? 
The user's responsibility

10. What is important when determining the scale-out approach to VMs, and what model is this referred to? The instances must be placed within an availability set. When determining the scale-out approach for VMs, it is important to determine the maximum number of VMs because that max number of VMs must be created