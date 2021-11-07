using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AzarketiWeaponExpertise : Template
    {
        public static readonly Guid ID = Guid.Parse("3eff4dd3-b1c8-4b2a-a77a-7e0709e0bc1e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Azarketi Weapon Expertise",
                Level = 13,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3ab34410-50b8-44a7-b2a8-e09b4dccbbc8"), Type = TextBlockType.Text, Text = "Your mastery with weapons both above and below water is unmatched. Whenever you gain a class feature that grants you expert or greater proficiency in certain weapons, you also gain that proficiency in (item: crossbows | crossbow), (item: hand crossbows | hand crossbow), (item: longspears | longspear), (item: spears | spear), (item: tridents | trident), and all azarketi weapons in which you are trained." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("8d4acfa0-3519-4bf4-81f3-b892500b13d5"), Feats.Instances.AzarketiWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b881ad39-1aef-49ce-a530-5d1580f79c0b"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
