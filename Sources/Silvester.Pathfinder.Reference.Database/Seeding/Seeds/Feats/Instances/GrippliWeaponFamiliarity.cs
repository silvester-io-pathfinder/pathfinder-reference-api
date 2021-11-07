using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrippliWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("6b3fd468-aee7-4904-b1dc-c161b6ca5ad5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grippli Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("1592cc10-729f-4c44-aa72-2e1db9aea262"), Type = TextBlockType.Text, Text = "You’ve trained with weapons ideally suited to marshes and dense forests. You are trained with (item: blowguns | Blowgun), (item: hatchets | Hatchet), (item: scythes | Scythe), (item: shortbows | Shortbow), and (item: composite shortbows | Composite Shortbow)." };
            yield return new TextBlock { Id = Guid.Parse("6f2b9ef8-bcb0-48ef-9261-ec972c19fbd5"), Type = TextBlockType.Text, Text = "You also gain access to all uncommon grippli weapons. For the purpose of determining your proficiency, martial grippli weapons are simple weapons, and advanced grippli weapons are martial weapons." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7f3b74c-43c8-4acb-b4e8-9a05a4653879"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
