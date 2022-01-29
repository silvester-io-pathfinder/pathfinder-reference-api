using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DevilInPlainSight : Template
    {
        public static readonly Guid ID = Guid.Parse("a5930313-83db-4914-bc6e-3d05c18f001d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Devil in Plain Sight",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("3e940874-32e5-4167-9711-91c6badee067"), Type = TextBlockType.Text, Text = $"You've learned to draw your fiendish nature into a small ball of corruption and hide it in your soul. Your obviously fiendish traits disappear, including any tails, horns, and cloven hooves, though hints remain (claws turn into jagged nails or eyes retain an odd hue, for instance). You're still recognizably yourself, but now appear as a typical, non-tiefling member of your base ancestry. Using Devil in Plain Sight counts as creating a disguise when using Deception to {ToMarkdownLink<Models.Entities.SkillAction>("Impersonate", SkillActions.Instances.Impersonate.ID)}, and your transformation automatically defeats Perception DCs to determine if you're a normal member of your base ancestry; only creatures actively rolling Perception to examine you might notice the disguise. While in your shapeshifted form, you can't use unarmed attacks, innate spells, or other abilities that require physical features you receive from a tiefling ancestry feat—for instance, you can't use the {ToMarkdownLink<Models.Entities.Feat>("Skillful Tail", Feats.Instances.SkillfulTail.ID)} feat. You can remain in your alternate form indefinitely, and can shift back to your tiefling form by using this action again." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("f650fa80-9e96-40c8-80a4-09ce490233df"), Traits.Instances.Concentrate.ID);
            builder.Add(Guid.Parse("d4377218-070c-4c47-8d12-ee4bdf560542"), Traits.Instances.Divine.ID);
            builder.Add(Guid.Parse("c3f331ba-2f0f-4725-91d7-f0bd2088f50e"), Traits.Instances.Polymorph.ID);
            builder.Add(Guid.Parse("4b76b5d4-0aa7-4448-9789-43fcb2b3c5a5"), Traits.Instances.Tiefling.ID);
            builder.Add(Guid.Parse("73008763-f3d9-4fc9-ba90-c168e768b0fb"), Traits.Instances.Transmutation.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("801d6b20-d79d-4286-bcc1-df271aef3ff3"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
