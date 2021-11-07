using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WestyrsWayfinderRepository : Template
    {
        public static readonly Guid ID = Guid.Parse("35d802e4-6326-4d00-806b-18482f9cdabc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Westyr's Wayfinder Repository",
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
            yield return new TextBlock { Id = Guid.Parse("8ad9449f-7226-4b39-8dee-2aec6f782f0b"), Type = TextBlockType.Text, Text = "You can use your wayfinder to store a little extra magic for when you need it most. When making your daily preparations, you can choose one 1st-level spell from your spellbook or spell repertoire and store it in your (item: wayfinder). You can cast this spell from the wayfinder using the normal actions required. Once the spell has been cast, it is expended, and you must make your next daily preparations to store another spell in your wayfinder." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("37b0a079-7246-4a7b-8afd-1f88cc98d05b"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("d171e84a-3108-4254-b922-803e011ad8c0"), Feats.Instances.WayfinderResonanceTinkerer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c0f19403-634e-46b2-a590-e0d8e2593e03"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
