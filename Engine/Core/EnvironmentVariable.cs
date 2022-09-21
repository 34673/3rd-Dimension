namespace ThirdDimension.Engine.Core{
	public class EnvironmentVariable<Type>{
		public readonly string name;
		public readonly string description;
		public enum AccessMode{System,User,Cheat}
		public readonly AccessMode accessMode;
		public Type value;
		public EnvironmentVariable(string name,Type value,AccessMode accessMode,string description = ""){
			this.name = name;
			this.value = value;
			this.accessMode = accessMode;
			this.description = description;
		}
	}
}
