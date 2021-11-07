using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OrcWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("2ee6e9d9-6adf-4383-98c1-57d6e173b02a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Orc Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("c88141f9-bd9f-4626-89ee-f6809c2e5a14"), Type = TextBlockType.Text, Text = "In combat, you favor the brutal weapons that are traditional for your orc ancestors. You are trained with the falchion and greataxe. In addition, you gain access to all uncommon orc weapons. For the purpose of determining your proficiency, martial orc weapons are simple weapons and advanced orc weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3d6e2f36-dbf8-489d-bc6d-eec63d7faa84"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
