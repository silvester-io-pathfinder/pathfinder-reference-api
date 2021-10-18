using Silvester.Pathfinder.Reference.Database.Models;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.SkillActions.Instances;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Classes.Instances
{
    public class Inventor : Template
    {
        public static readonly Guid ID = Guid.Parse("");

        protected override Class GetClass()
        {
            return new Class
            {
                Id = ID,
                Name = "Inventor",
                BaseHealth = 8,

                Description = "Any tinkerer can follow a diagram to make a device, but you invent the impossible! Every strange contraption you dream up is a unique experiment pushing the edge of possibility, a mysterious machine that seems to work for only you. You're always on the verge of the next great breakthrough, and every trial and tribulation is another opportunity to test and tune. If you can dream it, you can build it.",
                DuringCombatEncounters = "You rely on your inventions as much as possible, testing their functionalities under a variety of conditions. You don't set out to achieve anything as banal as simply winning a fight; you seek to collect valuable data that can be used to improve your creations!",
                DuringSocialEncounters = "You provide useful context when discussing a variety of academic topics, particularly when speaking about those subjects related to crafting and invention. You might often look for opportunities to acquire patronage to fund some of your more expensive or unorthodox experiments. After all, the materials needed to assemble your inventions don't pay for themselves!",
                WhileExploring = "You study the design and construction of the environments you explore ardently, making note of clever traps, ingenious mechanisms, or especially keen architecture you come across for later.",
                InDowntime = "You brainstorm new designs, bringing them to fruition through careful crafting and meticulous attention to detail. You might also modify previous inventions to adjust for data you've collected in the field. You might work as a local smith or tinker where your skills are needed, or you might keep a workshop on the edge of town where the clank and clatter of your experiments attracts less attention.",

                ClassDcProficiencyId = Proficiencies.Instances.Trained.ID,
                PerceptionProficiencyId = Proficiencies.Instances.Trained.ID,

                FortitudeProficiencyId = Proficiencies.Instances.Expert.ID,
                ReflexProficiencyId = Proficiencies.Instances.Trained.ID,
                WillProficiencyId = Proficiencies.Instances.Expert.ID,

                SimpleWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                MartialWeaponProficiencyId = Proficiencies.Instances.Trained.ID,
                AdvancedWeaponProficiencyId = Proficiencies.Instances.Untrained.ID,
                UnarmedWeaponProficiencyId = Proficiencies.Instances.Trained.ID,

                UnarmoredProficiencyId = Proficiencies.Instances.Trained.ID,
                LightArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                MediumArmorProficiencyId = Proficiencies.Instances.Trained.ID,
                HeavyArmorProficiencyId = Proficiencies.Instances.Untrained.ID,
            };
        }

        protected override IEnumerable<Guid> GetKeyAbilities()
        {
            yield return Stats.Instances.Intelligence.ID;
        }

        protected override IEnumerable<ClassMannerism> GetMannerisms()
        {
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Enjoy creating new things the world has never seen before." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Be willing to take a chance on a theory, testing to see if your hypothesis proves accurate. If not, you probably record the results to try again later." };
            yield return new ClassMannerism { Id = Guid.Parse(""), Text = "Wear clothes spattered with oil and grime, or venture off on excited and technical tangents when asked simple questions." };
        }

        protected override IEnumerable<ClassCharacteristic> GetCharacteristics()
        {
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Marvel at your inventions and the variety of unbelievable wonder they can bring." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Believe that you're a genius whose work is beyond understanding." };
            yield return new ClassCharacteristic { Id = Guid.Parse(""), Text = "Worry that your inventions might backfire or explode." };
        }
    }
}
