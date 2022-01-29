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
    public class InstrumentOfSlaughter : Template
    {
        public static readonly Guid ID = Guid.Parse("3ff2e244-747a-4640-b9c1-f1db28dfcc68");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Instrument of Slaughter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f82897aa-0de3-48fd-a8af-0bfc78d7d998"), Type = TextBlockType.Text, Text = $"Your blade ally thirsts for the blood of your foes. Whenever you critically hit an enemy with the weapon inhabited by your blade ally while dealing extra damage from your champion's reaction, the target takes persistent bleed damage equal to two of the weapon's damage dice." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificDivineAlly(Guid.Parse("48b95846-6508-4141-8b53-714709e3f055"), DivineAllies.Instances.Blade.ID);
            builder.HaveSpecificTenet(Guid.Parse("2b4dd714-58b0-4b5e-a5bc-153d478dec0c"), Tenets.Instances.Evil.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8540d924-b90c-4ec6-bf8b-fa4e2def3335"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
