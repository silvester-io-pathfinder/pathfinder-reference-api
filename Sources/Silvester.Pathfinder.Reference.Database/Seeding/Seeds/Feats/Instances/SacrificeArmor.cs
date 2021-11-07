using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SacrificeArmor : Template
    {
        public static readonly Guid ID = Guid.Parse("3810a6f4-d3cd-4179-8716-71b7406e0fd6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sacrifice Armor",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "You are hit by a Strike that deals physical damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d227621e-2111-47a0-ab9d-5f82ce22efe2"), Type = TextBlockType.Text, Text = "You twist your body to lessen the impact of an attack. Reduce the damage you take by an amount equal to twice your armor’s level. Your armor becomes broken, reducing its Hit Points to its Broken Threshold. If your armor was already damaged, it is destroyed instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("7f4af8d5-affc-4aa7-a47a-2f9bed47249c"), Feats.Instances.SentinelDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c5f91c5-8cb0-453b-a121-6ce24595300c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
