using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Alchemists
{
    public class AlchemicalAlacrity : Template
    {
        public static readonly Guid ID = Guid.Parse("49b0f526-bdd7-4f19-8e1a-fb33113f22ce");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Alchemical Alacrity", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("4c2a2b07-7bc2-406d-ba6b-78e292e65523"), Type = TextBlockType.Text, Text = "Your comfort in concocting items is such that you can create three at a time. When using the Quick Alchemy action, you can spend up to three batches of infused reagents to make up to three alchemical items as described in that action. These items do not have to be the same, and you automatically stow one of these new items as you create them." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d6867f4b-b32e-410e-bd9f-081049bd6231"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 76
            };
        }
    }
}
