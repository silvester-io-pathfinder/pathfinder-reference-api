using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CommunalSustain : Template
    {
        public static readonly Guid ID = Guid.Parse("10681338-72c3-4e15-a53e-4a83196699fd");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Communal Sustain",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per round"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8678cbe1-1d75-40a7-aedf-af356d76206f"), Type = TextBlockType.Text, Text = "Choose one spell with a sustained duration that one of your allies has in effect. You must be within 30 feet of the chosen ally. The ally can (action: Sustain the Spell | Sustain a Spell) once as a free action, triggered at the start of their next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e6817090-c3e8-4cfe-bc09-65ef2760f12d"), Feats.Instances.SpellmasterDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("18481e55-6af4-4746-93c2-61e0d3953eff"),
                SourceId = Sources.Instances.LostOmensSocietyGuide.ID,
                Page = -1
            };
        }
    }
}
