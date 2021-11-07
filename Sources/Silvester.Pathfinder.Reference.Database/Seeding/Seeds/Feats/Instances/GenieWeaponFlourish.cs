using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GenieWeaponFlourish : Template
    {
        public static readonly Guid ID = Guid.Parse("f7f6b8f9-dfe4-46d5-a782-741d90bf2b58");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Genie Weapon Flourish",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e7e1c7a0-1854-46b0-9610-984557f60dc4"), Type = TextBlockType.Text, Text = "Whenever you critically hit using a (item: falchion), (item: ranseur), (item: scimitar), (item: trident), or a (trait: geniekin | Geniekin - Item) weapon, you apply the weapon’s critical specialization effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("37ae56a3-17ec-4095-83fa-89d006145694"), Feats.Instances.GenieWeaponFamiliarity.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("887dd75f-d19d-4352-ab7d-8dd2d90ad91a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
