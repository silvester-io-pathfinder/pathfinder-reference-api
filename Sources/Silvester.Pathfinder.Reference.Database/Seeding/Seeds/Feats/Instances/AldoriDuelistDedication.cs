using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AldoriDuelistDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b7f2b3f1-745a-4d4a-9e64-c16e16b57781");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Aldori Duelist Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You cannot select another dedication feat until you have gained two other feats from the Aldori duelist archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("98da5c08-7dce-4ed4-8d45-059c1dc47cdf"), Type = TextBlockType.Text, Text = "~ Access: You are from the Broken Lands region." };
            yield return new TextBlock { Id = Guid.Parse("1113e472-c2b4-4b8c-a769-76e83a593fee"), Type = TextBlockType.Text, Text = "Your Aldori duelist training teaches you martial techniques and increases your dedication to the Aldori dueling sword. You become trained in your choice of Acrobatics or Athletics and in Dueling Lore; if you were already trained, you become an expert instead. Whenever your proficiency rank in any weapon increases to expert or beyond, you also gain that new proficiency rank with Aldori dueling swords. You gain access to Aldori dueling swords." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMeleeWeaponSpecificProficiency(Guid.Parse("bf353a0f-38e2-4fe3-b1b6-432331911b65"), Proficiencies.Instances.Trained.ID, MeleeWeapons.Instances.AldoriDuelingSword.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f910b052-34cb-40d1-8929-a8259d0bd82c"),
                SourceId = Sources.Instances.LostOmensWorldGuide.ID,
                Page = -1
            };
        }
    }
}
