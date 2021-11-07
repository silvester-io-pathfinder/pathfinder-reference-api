using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PiercingQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("a77c3fea-da01-4446-a20b-207fb6a96489");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Piercing Quills",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("276531aa-17c9-46aa-be63-b306e07eefef"), Type = TextBlockType.Text, Text = "Your quills can dig particularly deep into the flesh of your opponents. Your quills unarmed attack deals 1d4 persistent bleed damage on a critical hit." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4a625c33-ebd1-43cb-ad56-cf20e6e75fb8"), Feats.Instances.SpineStabber.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("05c36a84-fd82-45f5-aac1-15f8a904ad9e"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
