using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GrandTalismanEsoterica : Template
    {
        public static readonly Guid ID = Guid.Parse("79ed1163-ee50-4bc8-bf65-87cf9b6a8fce");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Grand Talisman Esoterica",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("219a878f-430f-40d8-874a-06e44f3bc13e"), Type = TextBlockType.Text, Text = "You have completed your journey in studying esoteric talismans, gaining yet more temporary talismans each day. You can create six temporary talismans each day instead of four." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("19304447-dac0-478c-b792-34b44e6561c2"), Feats.Instances.ElaborateTalismanEsoterica.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35686900-0f4c-40c5-92ca-966a68ad6d29"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
