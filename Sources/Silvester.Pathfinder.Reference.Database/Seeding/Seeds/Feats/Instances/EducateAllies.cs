using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EducateAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("b4827f83-e3a2-4e79-9787-faa74436f892");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Educate Allies",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally benefiting from one of your composition spells is subject to an effect with the auditory, illusion, linguistic, sonic, or visual trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("db5d066d-786f-41f5-8ac4-5242219a0451"), Type = TextBlockType.Text, Text = "You tweak the properties of your composition spell to convey a bit of your defensive knowledge. All allies affected by your composition spell gain your +1 circumstance bonus from (feat: Well-Versed) until the start of your next turn. Teaching your allies also bolsters your own skills; your personal circumstance bonus from (feat: Well-Versed) also increases to +2 until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("cdb23aa8-57b0-4054-893c-23883de3e2e3"), Feats.Instances.WellVersed.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3e9e0d71-185b-4474-a0c3-489d0ffa211f"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
