using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class PerpetualPerfection : Template
    {
        public static readonly Guid ID = Guid.Parse("38f92e76-2001-470b-a1d5-4ac381a1a660");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 17,
                Name = "Perpetual Perfection", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("d0591145-b6e5-4cfb-b983-5f1d2f9bfde4"), Type = TextBlockType.Text, Text = "You have perfected your perpetual infusions, allowing you to use Quick Alchemy to create even more powerful items at no cost.The items you can select depend on your research field and must be in your formula book." };
            yield return new TextBlock { Id = Guid.Parse("19eb5b46-f04f-499c-86de-92eaf2d4c570"), Type = TextBlockType.Enumeration, Text = "The greater versions of the bombs you chose for perpetual infusions." };
            yield return new TextBlock { Id = Guid.Parse("ae34243d-74c7-47eb-b403-44021148211d"), Type = TextBlockType.Enumeration, Text = "Greater antidote and antiplague." };
            yield return new TextBlock { Id = Guid.Parse("716dd176-7579-40f9-8b1d-e8940b34406c"), Type = TextBlockType.Enumeration, Text = "The greater versions of the mutagens you chose for perpetual infusions." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3c65e94b-7801-4b64-b485-bbb06ce0cd1e"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 76
            };
        }
    }
}
