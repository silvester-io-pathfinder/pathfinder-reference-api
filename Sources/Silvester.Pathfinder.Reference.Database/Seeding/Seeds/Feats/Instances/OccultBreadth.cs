using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OccultBreadth : Template
    {
        public static readonly Guid ID = Guid.Parse("cb8f6b7c-4fd5-4c23-94c5-0f683395a219");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Occult Breadth",
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
            yield return new TextBlock { Id = Guid.Parse("506f78dd-f0d4-4163-ac80-6f48876c8a83"), Type = TextBlockType.Text, Text = "Your repertoire expands, and you can cast more occult spells each day. Increase the number of spells in your repertoire and the number of spell slots you gain from bard archetype feats by 1 for each spell level other than your two highest bard spell slots." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c1f2b7ca-e7f5-4c20-8003-ec5b34a2b0a6"), Feats.Instances.BasicBardSpellcasting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3cd58c8f-bd65-4e38-a1bb-91e8c23fe29d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
