using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HalflingWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("2a7a6cc3-36b6-4b5a-a4b1-7db4b93cd649");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Halfling Weapon Familiarity",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e957b8c7-7d72-4e26-8f3d-bc07f8e5be28"), Type = TextBlockType.Text, Text = "You favor traditional halfling weapons, so you’ve learned how to use them more effectively. You have the trained proficiency with the sling, halfling sling staff, and shortsword." };
            yield return new TextBlock { Id = Guid.Parse("bf46e029-3f8f-439e-b95c-4023a0582a10"), Type = TextBlockType.Text, Text = "In addition, you gain access to all uncommon halfling weapons. For the purpose of determining your proficiency, martial halfling weapons are simple weapons and advanced halfling weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5675a8f6-7eb1-4c41-abe1-96fd20d20648"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
