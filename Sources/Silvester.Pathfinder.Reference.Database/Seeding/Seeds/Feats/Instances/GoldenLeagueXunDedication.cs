using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GoldenLeagueXunDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("10ba1871-dcae-4bae-a480-3267e721b55e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Golden League Xun Dedication",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the Golden League Xun archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f9e6530d-8d69-48b3-976e-4583dbb141dc"), Type = TextBlockType.Text, Text = "You are a xun for the Golden League, aiding the organization. You gain expert proficiency in two of the following skills (or in two other skills of your choice in which you&#39;re trained, if you were already an expert in the listed skills): Athletics, Deception, Intimidation, or Stealth. In addition, if you use Underworld Lore to (activity: Earn Income) or (action: Recall Knowledge), when you get a success, you get a critical success instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificLoreSpecificProficiency(Guid.Parse("74bda118-d7c6-47de-971f-4256fa2cd82f"), Proficiencies.Instances.Master.ID, Lores.Instances.Underworld.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f12fc3ee-a853-4198-830d-96c103127124"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
