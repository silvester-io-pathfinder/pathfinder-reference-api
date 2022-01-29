using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class WestyrsWayfinderRepository : Template
    {
        public static readonly Guid ID = Guid.Parse("4a6c31ff-5cca-4c00-9ccc-7a821027aeb4");

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
            yield return new TextBlock { Id = Guid.Parse("48d694ca-c09f-4361-840e-d152605dea33"), Type = TextBlockType.Text, Text = $"You can use your wayfinder to store a little extra magic for when you need it most. When making your daily preparations, you can choose one 1st-level spell from your spellbook or spell repertoire and store it in your {ToMarkdownLink<Models.Items.Instances.WornItem>("wayfinder", Items.WornItems.Instances.Wayfinder.ID)}. You can cast this spell from the wayfinder using the normal actions required. Once the spell has been cast, it is expended, and you must make your next daily preparations to store another spell in your wayfinder." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("d9e93fc0-8a1b-4842-838a-c7f0f9f2de5e"), Feats.Instances.PathfinderAgentDedication.ID);
            builder.HaveSpecificFeat(Guid.Parse("d4ed8e2d-f14b-4bdf-9309-6d43dfb8208a"), Feats.Instances.WayfinderResonanceTinkerer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("658ebe75-4a6e-4b20-ad96-1e37d2fb4ad5"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
