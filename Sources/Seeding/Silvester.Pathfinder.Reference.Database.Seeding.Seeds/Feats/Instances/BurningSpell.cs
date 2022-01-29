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
    public class BurningSpell : Template
    {
        public static readonly Guid ID = Guid.Parse("8bc64dce-f444-4ab0-a07a-9583942b0e88");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Burning Spell",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d21b05bd-6e34-454f-ad17-c6dc9858478b"), Type = TextBlockType.Text, Text = $"You enhance your spell with elemental fire, causing it to set the target on fire. If the next action you use is to {ToMarkdownLink<Models.Entities.Rule>("Cast a non-cantrip Spell", Rules.Instances.CastASpell.ID)} that deals damage at a single target, the spell deals additional persistent fire damage equal to the spell level, in addition to its other effects. This has no effect if the spell already deals persistent fire damage. The spell gains the {ToMarkdownLink<Models.Entities.Trait>("fire", Traits.Instances.Fire.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0fc302e7-0e83-4051-8f4e-b5cd2e4187f2"), Feats.Instances.ElementalistDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("3fe0d121-2419-44f0-9962-8d962ee0b141"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("bc769dab-cf45-4c1d-a99c-b425f5b66b7a"), Traits.Instances.Fire.ID);
            builder.Add(Guid.Parse("22690ab1-f8eb-4a04-a703-b83ec53e5330"), Traits.Instances.Metamagic.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("63ec3ac0-755e-413d-b412-ee1cfbe2eddb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
