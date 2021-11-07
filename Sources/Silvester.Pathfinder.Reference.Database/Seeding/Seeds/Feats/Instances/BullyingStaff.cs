using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class BullyingStaff : Template
    {
        public static readonly Guid ID = Guid.Parse("0dac0989-d972-41b8-af44-b1a302c96daa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Bullying Staff",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("88fad6cf-660a-4ec9-a945-42e7a44f5a49"), Type = TextBlockType.Text, Text = "You can attempt to (action: Shove) or (action: Trip) creatures up to two sizes larger than you. If you have master proficiency with your staff, you can attempt to (action: Shove) or (action: Trip) creatures up to three sizes larger than you." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("f2b20959-5ed6-4488-9c65-3571af04485f"), Feats.Instances.StaffAcrobatDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5e968cc7-ef13-4b74-85df-4e4ffb590dbb"),
                SourceId = Sources.Instances.ExtinctionCurse.ID,
                Page = -1
            };
        }
    }
}
