using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ConnectTheDots : Template
    {
        public static readonly Guid ID = Guid.Parse("3901b512-8046-4fd4-b93c-41d70bb98709");

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
            yield return new TextBlock { Id = Guid.Parse("cae781ed-5793-4db6-b42a-9429c4d0aa8f"), Type = TextBlockType.Text, Text = "Ephemeral connections between people, places, and concepts are invisible to most, but seeing them is your stock and trade. You spend 10 minutes considering two different leads you&#39;re pursuing. You then attempt a check to investigate how connected the two are. Unless the GM determines otherwise, this is a Crafting check if they&#39;re both items or a Society check for other combinations of leads. If any subjects are creatures, this check usually uses the highest DC among their Deception and Will DCs. If no subjects are creatures, but at least one is an item, the DC is usually a hard DC for the level of the highest-level item. If neither case applies, the DC is usually a hard expert or hard master DC (22 or 32). Once you try to Connect the Dots between two particular leads, you can never try to Connect the Dots between those same leads again unless the GM allows it after you&#39;ve learned a substantial amount of new information." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }

        protected override RollableEffect? GetRollableEffect()
        {
            return new RollableEffect
            {
                Id = Guid.Parse("06fe8208-5bf5-4efe-b964-bc568f0fdc00"),
                CriticalSuccess = "The GM tells you how connected the two leads are to one another: highly connected, somewhat connected, tangentially connected, or not connected. The GM also tells you one specific way in which they&#39;re connected, if they are.",
                Success = "As critical success, but the GM doesn&#39;t tell you a specific connection.",
                Failure = "Your results are inconclusive.",
                CriticalFailure = "You misconstrue the information. As success, but the GM provides an incorrect degree of connection.", 
            };
        }
            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("01ce996d-8784-4c88-af39-496817341fd3"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
