using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JalmeriHeavenseekerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("912045cb-129e-4335-b4a0-f070fc07f739");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Jalmeri Heavenseeker Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the Jalmeri heavenseeker archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e77e0d0d-8cc4-4d48-bef9-5feddd803918"), Type = TextBlockType.Text, Text = "~ Access: trained by a current or former member of a House of Perfection" };
            yield return new TextBlock { Id = Guid.Parse("26d9af50-eaf1-426a-a090-833ee708f105"), Type = TextBlockType.Text, Text = "Your skill and dedication have set you on a path to master the techniques of Jalmeray&#39;s greatest martial artists: victors of the Challenge of Sky and Heaven. You become trained in either Acrobatics or Occultism. You gain either the (feat: Ki Rush) or (feat: Ki Strike) monk feat, which grants you a ki spell and a focus pool of 1 Focus Point that you can recover using the (action: Refocus) activity as a monk does. If you already have both these feats, you can instead choose a single 1st-level monk feat." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificWeaponCategorySpecificProficiency(Guid.Parse("1ae12925-7d0a-49fc-a071-61e35eee0081"), Proficiencies.Instances.Expert.ID, WeaponCategories.Instances.Unarmed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86223068-72d5-47a2-b858-c3f16314aceb"),
                SourceId = Sources.Instances.AgentsOfEdgewatch.ID,
                Page = -1
            };
        }
    }
}
