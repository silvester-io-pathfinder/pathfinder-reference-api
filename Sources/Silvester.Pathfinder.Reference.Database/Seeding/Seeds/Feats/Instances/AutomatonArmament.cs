using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class AutomatonArmament : Template
    {
        public static readonly Guid ID = Guid.Parse("9954d663-6eac-4bf9-abff-12332e3be5b9");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Automaton Armament",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("05d3f11e-f54b-42e2-aba9-2e3e937acbff"), Type = TextBlockType.Text, Text = "You’ve been provided a body part designed for combat. You gain either a claw or pincer unarmed attack. The claw deals 1d4 slashing damage, is in the brawling group, and has the (trait: agile), (trait: finesse), and (trait: unarmed) traits. The pincer deals 1d6 piercing damage, is in the brawling group, and has the (trait: grapple) and (trait: unarmed) traits." };
            yield return new TextBlock { Id = Guid.Parse("de8235c6-3a57-4a01-9c46-8e03d184b487"), Type = TextBlockType.Text, Text = "Your body can be reconfigured; you can select this feat at any level, and you can retrain into or out of this feat or change the type of attack you gain." };
            yield return new TextBlock { Id = Guid.Parse("8982aa10-8004-4c67-b72b-975886e81910"), Type = TextBlockType.Text, Text = "----" };
            yield return new TextBlock { Id = Guid.Parse("cd0a466a-8b50-4d37-ac1c-0aabe1341b13"), Type = TextBlockType.Text, Text = "~ Enhancement: Your attacking part is reinforced. Increase the damage die of the unarmed attack you gain from this feat by one step (from 1d4 to 1d6, or from 1d6 to 1d8)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4374d8b0-d498-4c53-855a-2bf10d713db0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
