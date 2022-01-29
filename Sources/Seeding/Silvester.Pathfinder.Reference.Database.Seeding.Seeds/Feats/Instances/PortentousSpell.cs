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
    public class PortentousSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("dfd9ca6c-c9cb-419c-9f7b-083a8c905ccf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Portentous Spell",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e511af35-6513-48a3-8382-7645f0504f1f"), Type = TextBlockType.Text, Text = $"Your spellcasting is rife with strange lights, esoteric gestures, and other captivating effects that befuddle your foes. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)}, any creature that attempts to use a reaction triggered by your {ToMarkdownLink<Models.Entities.Rule>("Cast a Spell", Rules.Instances.CastASpell.ID)} activity takes a -2 circumstance penalty to attack rolls and skill checks rolled as part of the reaction. In addition, if the spell includes a spell attack roll or requires a saving throw, creatures you hit or that fail their saves are fascinated with you until the start of your next turn." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3320652b-2962-4bc4-8dcc-0a4f3053597f"), Traits.Instances.Manipulate.ID);
            builder.Add(Guid.Parse("f723b9b1-42de-44e7-8874-47c051d27ed8"), Traits.Instances.Mental.ID);
            builder.Add(Guid.Parse("ad6edb1a-ef0a-4612-bd20-5191eb4b1d6f"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("bc792ce7-62eb-42ef-aa8a-1169b3e393ea"), Traits.Instances.Oracle.ID);
            builder.Add(Guid.Parse("ef666974-afe9-4e85-9c96-382eec6cced4"), Traits.Instances.Visual.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c2c8aa16-38bb-40fb-86fd-ee68cbeae46f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
