using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ButterflyBladeDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("f5aafee6-d012-4c22-809e-c1e3359d2ed2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Butterfly Blade Dedication",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from this archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("71c718f0-0aed-4d72-9ed0-ad89ef33dfda"), Type = TextBlockType.Text, Text = "You become trained in Deception and Stealth; if you were already trained, you become an expert instead. Whenever your proficiency rank in any weapon increases to expert or beyond, you also gain that new proficiency rank with butterfly swords. You gain access to (item: butterfly swords | butterfly sword)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("9749814b-fa7b-42ad-b062-07f1868ea650"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.ButterflySword.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("35d9bb49-278b-41b5-823d-4a2e9f464100"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
