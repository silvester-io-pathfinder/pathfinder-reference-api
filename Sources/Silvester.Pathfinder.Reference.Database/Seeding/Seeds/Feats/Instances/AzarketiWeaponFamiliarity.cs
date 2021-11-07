using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("ee389028-4264-40aa-8e48-00efafbcfced");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("7ad09c19-4b0d-4f05-8f51-bb52eaf59a1c"), Type = TextBlockType.Text, Text = "You are familiar with weapons that excel underwater. You are trained with (item: crossbows | crossbow), (item: hand crossbows | hand crossbow), (item: longspears | longspear), (item: spears | spear), and (item: tridents | trident). In addition, you gain access to all uncommon azarketi weapons. For the purpose of determining your proficiency, martial azarketi weapons are simple weapons and advanced azarketi weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e86b8aa7-7b00-47c3-b6ad-50df885ed865"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
