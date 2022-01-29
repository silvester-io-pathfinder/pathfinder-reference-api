using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ModificationHeftyComposition : Template
    {
        public static readonly Guid ID = Guid.Parse("3ed28e87-df94-41a3-a139-93beee658dd5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Modification - Hefty Composition",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b3dbae7b-efa5-47ce-a070-564e4aa15367"), Type = TextBlockType.Enumeration, Text = $"*Melee Only**" };
            yield return new TextBlock { Id = Guid.Parse("17b161c2-c41e-40de-8ef8-c2e5d1e03475"), Type = TextBlockType.Text, Text = $"Blunt surfaces and sturdy construction make your weapon hefty and mace-like. Your innovation gains the {ToMarkdownLink<Models.Entities.Trait>("shove", Traits.Instances.Shove.ID)} and {ToMarkdownLink<Models.Entities.Trait>("versatile B", Traits.Instances.Versatile.ID)} traits." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("78aa8edd-3b8d-4359-a006-2cccaf47ff42"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
