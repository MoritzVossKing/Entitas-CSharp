//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public NameAgeComponent nameAge { get { return (NameAgeComponent)GetComponent(ComponentIds.NameAge); } }

        public bool hasNameAge { get { return HasComponent(ComponentIds.NameAge); } }

        public Entity AddNameAge(string newName, int newAge) {
            var component = CreateComponent<NameAgeComponent>(ComponentIds.NameAge);
            component.name = newName;
            component.age = newAge;
            return AddComponent(ComponentIds.NameAge, component);
        }

        public Entity ReplaceNameAge(string newName, int newAge) {
            var component = CreateComponent<NameAgeComponent>(ComponentIds.NameAge);
            component.name = newName;
            component.age = newAge;
            ReplaceComponent(ComponentIds.NameAge, component);
            return this;
        }

        public Entity RemoveNameAge() {
            return RemoveComponent(ComponentIds.NameAge);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherNameAge;

        public static IMatcher NameAge {
            get {
                if (_matcherNameAge == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.NameAge);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherNameAge = matcher;
                }

                return _matcherNameAge;
            }
        }
    }
}