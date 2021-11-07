using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SyuTakNwasHexedLocks : Template
    {
        public static readonly Guid ID = Guid.Parse("07383428-bce3-437e-8109-6d7d137cbc8f");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Syu Tak-Nwa's Hexed Locks",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("bb691767-6f45-486a-b423-4ea49c431266"), Type = TextBlockType.Text, Text = "Your hair unarmed attack gains the (trait: reach) trait. You can deliver hexes through your hair. When you successfully cast a hex focus spell that requires 2 or more actions to cast and that doesn&#39;t require a spell attack roll, if your target is within your reach, as part of the spellcasting activity you can make a hair (action: Strike) against the foe before applying any effects of the hex. If this (action: Strike) misses, the hex has no effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("a038eb3e-1173-4cd4-a527-3179f03906ba"), Feats.Instances.LivingHair.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6e8fe818-f78e-4173-ab0e-2a20203e0e46"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
