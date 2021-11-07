using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CourageousOnslaught : Template
    {
        public static readonly Guid ID = Guid.Parse("feab6558-651c-4521-bb9f-7d94a59dded2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Courageous Onslaught",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7c9a4fdd-d456-4b71-b27a-143293492d8a"), Type = TextBlockType.Text, Text = "You use your performance to orchestrate an onslaught against your enemies. If your next action is to cast the (spell: inspire courage) composition cantrip, one ally who gains a status bonus from the spell can immediately use a reaction to (action: Stride) and then make a melee (action: Strike)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1d506a1f-a101-40da-bb02-2a0047f2e132"), Feats.Instances.CourageousAdvance.ID);
            builder.HaveSpecificFeat(Guid.Parse("71f61bd6-4d48-4cf8-8dce-d2ee42e20cf6"), Feats.Instances.CourageousAssault.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("400c33af-dc17-471e-a64e-2bf25996fa99"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
