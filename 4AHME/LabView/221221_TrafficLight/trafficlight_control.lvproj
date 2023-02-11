<?xml version='1.0' encoding='UTF-8'?>
<Project Type="Project" LVVersion="22308000">
	<Item Name="My Computer" Type="My Computer">
		<Property Name="server.app.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.control.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="server.tcp.enabled" Type="Bool">false</Property>
		<Property Name="server.tcp.port" Type="Int">0</Property>
		<Property Name="server.tcp.serviceName" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.tcp.serviceName.default" Type="Str">My Computer/VI Server</Property>
		<Property Name="server.vi.callsEnabled" Type="Bool">true</Property>
		<Property Name="server.vi.propertiesEnabled" Type="Bool">true</Property>
		<Property Name="specify.custom.address" Type="Bool">false</Property>
		<Item Name="Controls" Type="Folder">
			<Item Name="Ampel.ctl" Type="VI" URL="../Ampel.ctl"/>
			<Item Name="TrafficLight.ctl" Type="VI" URL="../TrafficLight.ctl"/>
		</Item>
		<Item Name="230209_Trafficlight_Sync.vi" Type="VI" URL="../230209_Trafficlight_Sync.vi"/>
		<Item Name="TrafficLight.jpg" Type="Document" URL="../TrafficLight.jpg"/>
		<Item Name="trafficlight_main.vi" Type="VI" URL="../trafficlight_main.vi"/>
		<Item Name="trafficlight_main_stateengine.vi" Type="VI" URL="../trafficlight_main_stateengine.vi"/>
		<Item Name="trafficlight_Test.vi" Type="VI" URL="../trafficlight_Test.vi"/>
		<Item Name="Dependencies" Type="Dependencies"/>
		<Item Name="Build Specifications" Type="Build"/>
	</Item>
</Project>
