using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GhostEaterDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("9a986e39-e9f2-4609-a8f3-2b6fb2936bd2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Eater Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ca4c8182-65a3-423e-b271-1a995773d794"), Type = TextBlockType.Text, Text = "You have trained as a ghost eater, a hunter specialized in the destruction of spirits. You know how to channel your own spiritual energy to harm spirits. Your weapon and unarmed attack (action: Strikes | Strike) become magical. Against incorporeal creatures, they also gain the effects of a (item: ghost touch property rune | Ghost Touch Runestone)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("f31d4c50-a2a9-4cb2-8013-180af4eb0db3"), or => 
            {
                or.HaveSpecificSkillProficiency(Guid.Parse("d6d022fc-5616-424b-acb7-93208bd36f0c"), Proficiencies.Instances.Trained.ID, Skills.Instances.Occultism.ID);
                or.HaveSpecificSkillProficiency(Guid.Parse("c297a622-d246-4612-8185-5119f09fe0e3"), Proficiencies.Instances.Trained.ID, Skills.Instances.Religion.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("c55dee6d-4fb4-4f52-ac9d-0429e9c58cfc"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
