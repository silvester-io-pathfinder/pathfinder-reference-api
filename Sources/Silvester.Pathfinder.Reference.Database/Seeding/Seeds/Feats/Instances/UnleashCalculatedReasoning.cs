using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashCalculatedReasoning : Template
    {
        public static readonly Guid ID = Guid.Parse("640eb99e-f6a9-4b3e-99f6-a13ce2c6a897");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Calculated Reasoning",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ae606d6b-4854-420b-84f6-d28f6fe65203"), Type = TextBlockType.Text, Text = "Your mind overflows with the calculated confidence that all results should be exactly what you’ve determined them to be." };
            yield return new TextBlock { Id = Guid.Parse("50f8e98b-b344-4136-933b-7814a02eaa62"), Type = TextBlockType.Text, Text = "~ Benefit: While this psyche is Unleashed, when you would roll damage for a spell, you can instead choose to deal half the spell’s maximum damage instead of rolling. (This is the full damage and is still halved on a half damage result, doubled on a double damage result, and so on.)" };
            yield return new TextBlock { Id = Guid.Parse("8a85c330-fc76-4cb2-a9a7-9fe256a64a13"), Type = TextBlockType.Text, Text = "~ Drawback: Unlike other psyches, Unleash Calculated Reasoning has no drawback. You’ve taken everything into account and canceled all of the drawbacks out." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("8edfc563-ccf2-4525-9ba6-a4a9d312b3b0"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
