using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Clerics
{
    public class Anathema : Template
    {
        public static readonly Guid ID = Guid.Parse("3ced19f4-4e29-4710-8f09-abada351d551");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 1,
                Name = "Anathema", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("66dac80b-065d-425b-a26a-bed70f3833ec"), Type = TextBlockType.Text, Text = "As stewards of the natural order, druids find affronts to nature anathema. If you perform enough acts that are anathema to nature, you lose your magical abilities that come from the druid class, including your primal spellcasting and the benefits of your order. These abilities can be regained only if you demonstrate your repentance by conducting an atone ritual." };
            yield return new TextBlock { Id = Guid.Parse("5055d66c-bc98-4f30-82df-c38d111906c0"), Type = TextBlockType.Text, Text = "The following acts are anathema to all druids:" };
            yield return new TextBlock { Id = Guid.Parse("0977e246-158a-4efa-ad37-c99b36dfcaa2"), Type = TextBlockType.Enumeration, Text = "Using metal armor or shields." };
            yield return new TextBlock { Id = Guid.Parse("c0155149-0768-413c-b325-bde56dc0d9e7"), Type = TextBlockType.Enumeration, Text = "Despoiling natural places." };
            yield return new TextBlock { Id = Guid.Parse("24f4120a-e4c1-42e6-b46f-8348bb5b53a4"), Type = TextBlockType.Enumeration, Text = "Teaching the Druidic language to non-druids." };
            yield return new TextBlock { Id = Guid.Parse("3f9e19e1-2af9-4e56-9f10-e7a33ab5e0f0"), Type = TextBlockType.Text, Text = "Each druidic order also has additional anathema acts, detailed in the order�s entry." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e5084837-7d99-4c93-8541-b92ebcdebf2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 130
            };
        }
    }
}
