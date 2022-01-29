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
    public class InterweaveDispel : Template
    {
        public static readonly Guid ID = Guid.Parse("c5857e84-4d6d-49bd-9884-7ff52f87f9ce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Interweave Dispel",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a62ccb0d-5a66-4967-8fe8-4ae0453f00e7"), Type = TextBlockType.Text, Text = $"You weave dispelling energy into a spell, sending both effects at a foe. If your next action is to cast a single-target spell against a creature, and you either hit the foe with the spell attack roll or the foe fails its saving throw, you can cast {ToMarkdownLink<Models.Entities.Spell>("dispel magic", Spells.Instances.DispelMagic.ID)} on the foe as a free action, expending a spell slot as normal and targeting one spell effect affecting the foe." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSpell(Guid.Parse("361abc02-ba04-4ccc-b9f4-7e3b0cfec58a"), Spells.Instances.DispelMagic.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("e756578f-aee3-40b1-95bf-9452ce36ce1b"), Traits.Instances.Metamagic.ID);
            builder.Add(Guid.Parse("18ca9f18-9ff8-4e06-88c2-9ac0d8a89188"), Traits.Instances.Sorcerer.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1fa821f0-4f14-43c7-b6b8-b3ae19fba513"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
