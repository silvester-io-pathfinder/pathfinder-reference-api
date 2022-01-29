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
    public class ConnectTheDots : Template
    {
        public static readonly Guid ID = Guid.Parse("b8636f1f-cdbd-4c93-af0e-4e3ffca803de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Connect the Dots",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db57b336-515b-4330-b017-a2a9d3b71373"), Type = TextBlockType.Text, Text = $"Ephemeral connections between people, places, and concepts are invisible to most, but seeing them is your stock and trade. You spend 10 minutes considering two different leads you're pursuing. You then attempt a check to investigate how connected the two are. Unless the GM determines otherwise, this is a Crafting check if they're both items or a Society check for other combinations of leads. If any subjects are creatures, this check usually uses the highest DC among their Deception and Will DCs. If no subjects are creatures, but at least one is an item, the DC is usually a hard DC for the level of the highest-level item. If neither case applies, the DC is usually a hard expert or hard master DC (22 or 32). Once you try to Connect the Dots between two particular leads, you can never try to Connect the Dots between those same leads again unless the GM allows it after you've learned a substantial amount of new information." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("89543b5f-f875-4472-87cd-a94cc1ff782c"),
                CriticalSuccess = "The GM tells you how connected the two leads are to one another: highly connected, somewhat connected, tangentially connected, or not connected. The GM also tells you one specific way in which they're connected, if they are.",
                Success = "As critical success, but the GM doesn't tell you a specific connection.",
                Failure = "Your results are inconclusive.",
                CriticalFailure = "You misconstrue the information. As success, but the GM provides an incorrect degree of connection.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ed67ea85-d2cc-4050-a620-21476734cd87"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
