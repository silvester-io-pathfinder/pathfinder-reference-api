using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ImprovisedCrafting : Template
    {
        public static readonly Guid ID = Guid.Parse("582a0638-ae4e-4495-8ffa-3751e8d4e9e5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Improvised Crafting",
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
            yield return new TextBlock { Id = Guid.Parse("afb9902e-3154-455e-83bc-e9728e9a57d0"), Type = TextBlockType.Text, Text = "You&#39;ve learned to repair your equipment even in challenging circumstances, making use of what you have available. You can attempt to (action: Repair) an item without a (item: repair kit), instead improvising tools out of your gear or found items. This adds 5 minutes to the time it takes to (action: Repair) the item. You can also (action: Repair) an item while on the move without needing a stable surface. This adds 10 minutes to the times it takes to (action: Repair) the item." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6eef0c7f-ca39-4cd1-8cd3-29b4cad1889d"), Feats.Instances.SwordmasterDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("48383586-2a9f-4a96-a921-a0f9352aab5b"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("dd13bd1c-0fa0-4c9e-843f-e38e47ba1e82"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
